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

namespace Transmitly.ChannelProvider.Twilio.Configuration.Voice
{
	/// <summary>
	/// Twilio specific properties for the voice channel.
	/// </summary>
	public interface IExtendedVoiceChannelProperties
	{
		MachineDetection? MachineDetection { get; set; }
		Func<string, IVoice, IDispatchCommunicationContext, Task>? OnStoreMessageForRetrievalAsync { get; set; }
		string? StatusCallbackMethod { get; set; }
		string? StatusCallbackUrl { get; set; }
		Func<IDispatchCommunicationContext, Task<string?>>? StatusCallbackUrlResolver { get; set; }
		int? Timeout { get; set; }
		string? Url { get; set; }
		HttpMethod? UrlMethod { get; set; }
		Func<IDispatchCommunicationContext, Task<string?>>? UrlResolver { get; set; }
	}
}