// Copyright (c) Code Impressions, LLC. All Rights Reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License")
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

using Transmitly.ChannelProvider.Twilio.Configuration.Sms;
using Transmitly.ChannelProvider.Twilio.Configuration.Voice;
using Transmitly.Delivery;

namespace Transmitly.ChannelProvider.Twilio.ConfigurationTests
{
	[TestClass]
	public sealed class StatusReportTests
	{
		// Property name => header Twilio sends it in. Every other property is named after its callback field.
		private static readonly Dictionary<string, string> HeaderFields = new()
		{
			["Signature"] = "x-twilio-signature",
			["IdempotencyId"] = "i-twilio-idempotency-token",
			["HomeRegion"] = "x-home-region"
		};

		// Fields that need a real Twilio value to parse; the rest accept "1".
		private static readonly Dictionary<string, string> Samples = new()
		{
			["Direction"] = "inbound",
			["CallStatus"] = "completed",
			["MessageStatus"] = "delivered",
			["SmsStatus"] = "delivered",
			["Timestamp"] = "Mon, 16 Aug 2010 03:45:01 +0000"
		};

		[TestMethod]
		public void VoiceReport_ReadsEveryField()
		{
			var report = new VoiceStatusReport(CallbackFor<VoiceStatusReport>());

			AssertEverythingSet(report);
			Assert.AreEqual(Direction.Inbound, report.Direction);
		}

		[TestMethod]
		public void SmsReport_ReadsEveryField()
		{
			AssertEverythingSet(new SmsStatusReport(CallbackFor<SmsStatusReport>()));
		}

		[TestMethod]
		public void VoiceReport_SentAsGet_ReadsTheQuery()
		{
			var report = new VoiceStatusReport(new Request(query: new() { ["CallSid"] = "CA1", ["CallStatus"] = "completed" }));

			Assert.AreEqual("CA1", report.CallSid);
			Assert.AreEqual(CallStatus.Completed, report.CallStatus);
		}

		[TestMethod]
		public void HeaderValues_AreNotTakenFromTheForm()
		{
			var report = new SmsStatusReport(new Request(form: new() { ["x-twilio-signature"] = "forged" }));

			Assert.IsNull(report.Signature);
		}

		[TestMethod]
		public void UnknownStatus_IsNull()
		{
			var report = new SmsStatusReport(new Request(form: new() { ["MessageStatus"] = "brand_new_status" }));

			Assert.IsNull(report.MessageStatus);
		}

		private static Request CallbackFor<T>()
		{
			var properties = typeof(T).GetProperties().Select(p => p.Name).ToList();
			return new Request(
				form: properties.Where(p => !HeaderFields.ContainsKey(p)).ToDictionary(p => p, p => Samples.TryGetValue(p, out var v) ? v : "1"),
				headers: HeaderFields.ToDictionary(h => h.Value, h => "1"));
		}

		private static void AssertEverythingSet(object report)
		{
			foreach (var property in report.GetType().GetProperties())
				Assert.IsNotNull(property.GetValue(report), $"{property.Name} was not read from the callback.");
		}

		private sealed class Request(Dictionary<string, string>? form = null, Dictionary<string, string>? query = null, Dictionary<string, string>? headers = null) : IRequestAdaptorContext
		{
			public string? GetQueryValue(string key) => Get(query, key);
			public string? GetFormValue(string key) => Get(form, key);
			public string? GetHeaderValue(string key) => Get(headers, key);
			public string? GetValue(string key) => throw new NotSupportedException("Use GetQueryValue, GetFormValue or GetHeaderValue.");
			public string? Content => null;
			public string? RequestUrl => null;
			public string? PipelineIntent => null;
			public string? PipelineId => null;
			public string? ResourceId => null;

			private static string? Get(Dictionary<string, string>? values, string key) => values != null && values.TryGetValue(key, out var v) ? v : null;
		}
	}
}
