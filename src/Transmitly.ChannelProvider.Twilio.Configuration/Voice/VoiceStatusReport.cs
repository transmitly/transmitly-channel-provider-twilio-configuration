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

using System;
using System.Globalization;
using Transmitly.Delivery;
using Transmitly.Util;

namespace Transmitly.ChannelProvider.Twilio.Configuration.Voice
{
	public sealed class VoiceStatusReport : StatusReport
	{
		public VoiceStatusReport(IRequestAdaptorContext adaptorContext) : base(adaptorContext)
		{
			Guard.AgainstNull(adaptorContext);

			Called = GetField(adaptorContext, "Called");
			ToState = GetField(adaptorContext, "ToState");
			CallerCountry = GetField(adaptorContext, "CallerCountry");
			CallbackSource = GetField(adaptorContext, "CallbackSource");
			SipResponseCode = GetField(adaptorContext, "SipResponseCode");
			CallerState = GetField(adaptorContext, "CallerState");
			ToZip = GetField(adaptorContext, "ToZip");
			CallSid = GetField(adaptorContext, "CallSid");
			CallerZip = GetField(adaptorContext, "CallerZip");
			ToCountry = GetField(adaptorContext, "ToCountry");
			CalledZip = GetField(adaptorContext, "CalledZip");
			CalledCity = GetField(adaptorContext, "CalledCity");
			CalledCountry = GetField(adaptorContext, "CalledCountry");
			CallerCity = GetField(adaptorContext, "CallerCity");
			ToCity = GetField(adaptorContext, "ToCity");
			FromCountry = GetField(adaptorContext, "FromCountry");
			CalledState = GetField(adaptorContext, "CalledState");
			FromZip = GetField(adaptorContext, "FromZip");
			AnsweredBy = GetField(adaptorContext, "AnsweredBy");
			FromState = GetField(adaptorContext, "FromState");
			Caller = GetField(adaptorContext, "Caller");
			FromCity = GetField(adaptorContext, "FromCity");

			if (DateTimeOffset.TryParse(GetField(adaptorContext, "Timestamp"), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out var timestamp))
				Timestamp = timestamp;

			if (int.TryParse(GetField(adaptorContext, "SequenceNumber"), out var sequenceNumber))
				SequenceNumber = sequenceNumber;

			if (int.TryParse(GetField(adaptorContext, "Duration"), out var duration))
				Duration = TimeSpan.FromMinutes(duration);

			if (int.TryParse(GetField(adaptorContext, "CallDuration"), out var callDuration))
				CallDuration = TimeSpan.FromSeconds(callDuration);

			CallStatus = EnumUtil.ToEnum<CallStatus>(GetField(adaptorContext, "CallStatus"));
			Direction = EnumUtil.ToEnum<Direction>(GetField(adaptorContext, "Direction"));
		}

		public string? Called { get; }

		public string? ToState { get; }

		public string? CallerCountry { get; }

		public Direction? Direction { get; }

		public DateTimeOffset? Timestamp { get; }

		public string? CallbackSource { get; }

		public string? SipResponseCode { get; }

		public string? CallerState { get; }

		public string? ToZip { get; }

		public int? SequenceNumber { get; }

		public string? CallSid { get; }

		public string? CallerZip { get; }

		public string? ToCountry { get; }

		public string? CalledZip { get; }

		public string? CalledCity { get; }

		public CallStatus? CallStatus { get; }

		/// <summary>
		/// The duration of the just-completed call; 
		/// calls are billed by the minute. 
		/// Only present in the completed event.
		/// </summary>
		public TimeSpan? Duration { get; }

		/// <summary>
		/// The duration of the just-completed call. 
		/// Only present in the completed event
		/// </summary>
		public TimeSpan? CallDuration { get; }

		public string? CalledCountry { get; }

		public string? CallerCity { get; }

		public string? ToCity { get; }

		public string? FromCountry { get; }

		public string? Caller { get; }

		public string? FromCity { get; }

		public string? CalledState { get; }

		public string? FromZip { get; }

		public string? AnsweredBy { get; }

		public string? FromState { get; }

	}
}
