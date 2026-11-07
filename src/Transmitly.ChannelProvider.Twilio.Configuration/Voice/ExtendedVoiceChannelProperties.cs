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
using System.Net.Http;
using System.Threading.Tasks;
using Transmitly.Util;

namespace Transmitly.ChannelProvider.Twilio.Configuration.Voice
{
	internal sealed class ExtendedVoiceChannelProperties(IExtendedProperties extendedProperties) : IExtendedVoiceChannelProperties
	{
		private readonly IExtendedProperties _extendedProperties = Guard.AgainstNull(extendedProperties);
		private const string ProviderKey = TwilioConstant.VoicePropertiesKey;

		public MachineDetection? MachineDetection
		{
			get => _extendedProperties.GetValue<MachineDetection?>(ProviderKey, nameof(MachineDetection));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(MachineDetection), value);
		}

		public Func<string, IVoice, IDispatchCommunicationContext, Task>? OnStoreMessageForRetrievalAsync
		{
			get => _extendedProperties.GetValue<Func<string, IVoice, IDispatchCommunicationContext, Task>?>(ProviderKey, nameof(OnStoreMessageForRetrievalAsync));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(OnStoreMessageForRetrievalAsync), value);
		}

		public string? StatusCallbackMethod
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(StatusCallbackMethod));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(StatusCallbackMethod), value);
		}

		public string? StatusCallbackUrl
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(StatusCallbackUrl));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(StatusCallbackUrl), value);
		}

		public Func<IDispatchCommunicationContext, Task<string?>>? StatusCallbackUrlResolver
		{
			get => _extendedProperties.GetValue<Func<IDispatchCommunicationContext, Task<string?>>?>(ProviderKey, nameof(StatusCallbackUrlResolver));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(StatusCallbackUrlResolver), value);
		}

		public int? Timeout
		{
			get => _extendedProperties.GetValue<int?>(ProviderKey, nameof(Timeout));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(Timeout), value);
		}

		public string? Url
		{
			get => _extendedProperties.GetValue<string?>(ProviderKey, nameof(Url));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(Url), value);
		}

		public HttpMethod? UrlMethod
		{
			get => _extendedProperties.GetValue<HttpMethod?>(ProviderKey, nameof(UrlMethod));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(UrlMethod), value);
		}

		public Func<IDispatchCommunicationContext, Task<string?>>? UrlResolver
		{
			get => _extendedProperties.GetValue<Func<IDispatchCommunicationContext, Task<string?>>?>(ProviderKey, nameof(UrlResolver));
			set => _extendedProperties.AddOrUpdate(ProviderKey, nameof(UrlResolver), value);
		}
	}
}
