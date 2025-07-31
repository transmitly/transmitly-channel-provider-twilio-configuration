// ﻿﻿Copyright (c) Code Impressions, LLC. All Rights Reserved.
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
using Transmitly.ChannelProvider.Twilio.Configuration.Voice;

namespace Transmitly.ChannelProvider.Twilio.Configuration
{
	sealed class EmptyExtendedVoiceDeliveryReportProperties : IExtendedVoiceDeliveryReportProperties
	{
		public string? AccountSid { get;set; }
		public string? AnsweredBy { get;set; }
		public string? ApiVersion { get;set; }
		public string? CallbackSource { get;set; }
		public TimeSpan? CallDuration { get;set; }
		public string? Called { get;set; }
		public string? CalledCity { get;set; }
		public string? CalledCountry { get;set; }
		public string? CalledState { get;set; }
		public string? CalledZip { get;set; }
		public string? Caller { get;set; }
		public string? CallerCity { get;set; }
		public string? CallerCountry { get;set; }
		public string? CallerState { get;set; }
		public string? CallerZip { get;set; }
		public string? CallSid { get;set; }
		public CallStatus? CallStatus { get;set; }
		public Direction? Direction { get;set; }
		public TimeSpan? Duration { get;set; }
		public string? From { get;set; }
		public string? FromCity { get;set; }
		public string? FromCountry { get;set; }
		public string? FromState { get;set; }
		public string? FromZip { get;set; }
		public string? IdempotencyId { get;set; }
		public int? SequenceNumber { get;set; }
		public string? Signature { get;set; }
		public string? SipResponseCode { get;set; }
		public DateTimeOffset? Timestamp { get;set; }
		public string? To { get;set; }
		public string? ToCity { get;set; }
		public string? ToCountry { get;set; }
		public string? ToState { get;set; }
		public string? ToZip { get;set; }
	}
}
