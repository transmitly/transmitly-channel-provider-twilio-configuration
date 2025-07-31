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

using Transmitly.ChannelProvider.Twilio.Configuration.Sms;

namespace Transmitly.ChannelProvider.Twilio.Configuration
{
	sealed class EmptyExtendedSmsDeliveryReportProperties : IExtendedSmsDeliveryReportProperties
	{
		public string? AccountSid { get;set; }
		public string? ApiVersion { get;set; }
		public string? ErrorCode { get;set; }
		public string? From { get;set; }
		public string? HomeRegion { get;set; }
		public string? IdempotencyId { get;set; }
		public string? MessageSid { get;set; }
		public SmsStatus? MessageStatus { get;set; }
		public string? Signature { get;set; }
		public string? SmsSid { get;set; }
		public SmsStatus? SmsStatus { get;set; }
		public string? To { get;set; }
	}
}
