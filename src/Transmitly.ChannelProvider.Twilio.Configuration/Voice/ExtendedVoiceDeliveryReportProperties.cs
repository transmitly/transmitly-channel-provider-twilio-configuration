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
using Transmitly.Util;

namespace Transmitly.ChannelProvider.Twilio.Configuration.Voice
{
	internal sealed class ExtendedVoiceDeliveryReportProperties(IExtendedProperties extendedProperties) : IExtendedVoiceDeliveryReportProperties
	{
		private readonly IExtendedProperties _extendedProperties = Guard.AgainstNull(extendedProperties);
		private const string ProviderKey = TwilioConstant.VoicePropertiesKey;

		public string? AccountSid
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(AccountSid));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(AccountSid), value);
		}

		public string? AnsweredBy
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(AnsweredBy));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(AnsweredBy), value);
		}

		public string? ApiVersion
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(ApiVersion));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(ApiVersion), value);
		}

		public string? CallbackSource
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(CallbackSource));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(CallbackSource), value);
		}

		public TimeSpan? CallDuration
		{
			get => _extendedProperties.GetValue<TimeSpan?>(ProviderKey, nameof(CallDuration));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(CallDuration), value);
		}

		public string? Called
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(Called));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(Called), value);
		}

		public string? CalledCity
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(CalledCity));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(CalledCity), value);
		}

		public string? CalledCountry
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(CalledCountry));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(CalledCountry), value);
		}

		public string? CalledState
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(CalledState));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(CalledState), value);
		}

		public string? CalledZip
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(CalledZip));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(CalledZip), value);
		}

		public string? Caller
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(Caller));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(Caller), value);
		}

		public string? CallerCity
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(CallerCity));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(CallerCity), value);
		}

		public string? CallerCountry
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(CallerCountry));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(CallerCountry), value);
		}

		public string? CallerState
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(CallerState));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(CallerState), value);
		}

		public string? CallerZip
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(CallerZip));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(CallerZip), value);
		}

		public string? CallSid
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(CallSid));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(CallSid), value);
		}

		public CallStatus? CallStatus
		{
			get => _extendedProperties.GetValue<CallStatus?>(ProviderKey, nameof(CallStatus));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(CallStatus), value);
		}

		public Direction? Direction
		{
			get => _extendedProperties.GetValue<Direction?>(ProviderKey, nameof(Direction));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(Direction), value);
		}

		public TimeSpan? Duration
		{
			get => _extendedProperties.GetValue<TimeSpan?>(ProviderKey, nameof(Duration));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(Duration), value);
		}

		public string? From
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(From));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(From), value);
		}

		public string? FromCity
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(FromCity));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(FromCity), value);
		}

		public string? FromCountry
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(FromCountry));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(FromCountry), value);
		}

		public string? FromState
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(FromState));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(FromState), value);
		}

		public string? FromZip
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(FromZip));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(FromZip), value);
		}

		public string? IdempotencyId
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(IdempotencyId));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(IdempotencyId), value);
		}

		public int? SequenceNumber
		{
			get => _extendedProperties.GetValue<int?>(ProviderKey, nameof(SequenceNumber));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(SequenceNumber), value);
		}

		public string? Signature
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(Signature));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(Signature), value);
		}

		public string? SipResponseCode
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(SipResponseCode));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(SipResponseCode), value);
		}

		public DateTimeOffset? Timestamp
		{
			get => _extendedProperties.GetValue<DateTimeOffset?>(ProviderKey, nameof(Timestamp));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(Timestamp), value);
		}

		public string? To
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(To));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(To), value);
		}

		public string? ToCity
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(ToCity));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(ToCity), value);
		}

		public string? ToCountry
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(ToCountry));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(ToCountry), value);
		}

		public string? ToState
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(ToState));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(ToState), value);
		}

		public string? ToZip
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(ToZip));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(ToZip), value);
		}
	}
}
