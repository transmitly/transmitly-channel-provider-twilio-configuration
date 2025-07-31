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
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Transmitly.Channel.Configuration.Voice;
using Transmitly.ChannelProvider.Twilio.Configuration.Voice;

namespace Transmitly.ChannelProvider.Twilio.Configuration
{
	sealed class EmptyExtendedVoiceChannelProperties : IExtendedVoiceChannelProperties
	{
		public MachineDetection? MachineDetection { get;set; }
		public Func<string, IVoice, IDispatchCommunicationContext, Task>? OnStoreMessageForRetrievalAsync { get;set; }
		public string? StatusCallbackMethod { get;set; }
		public string? StatusCallbackUrl { get;set; }
		public Func<IDispatchCommunicationContext, Task<string?>>? StatusCallbackUrlResolver { get;set; }
		public int? Timeout { get;set; }
		public string? Url { get;set; }
		public HttpMethod? UrlMethod { get;set; }
		public Func<IDispatchCommunicationContext, Task<string?>>? UrlResolver { get;set; }

		public IExtendedVoiceChannelProperties Adapt(IVoiceChannelConfiguration sms)
		{
			return this;
		}

		public AttributeCollection GetAttributes()
		{
			throw new NotImplementedException();
		}

		public string GetClassName()
		{
			throw new NotImplementedException();
		}

		public string GetComponentName()
		{
			throw new NotImplementedException();
		}

		public TypeConverter GetConverter()
		{
			throw new NotImplementedException();
		}

		public EventDescriptor GetDefaultEvent()
		{
			throw new NotImplementedException();
		}

		public PropertyDescriptor GetDefaultProperty()
		{
			throw new NotImplementedException();
		}

		public object GetEditor(Type editorBaseType)
		{
			throw new NotImplementedException();
		}

		public EventDescriptorCollection GetEvents()
		{
			throw new NotImplementedException();
		}

		public EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			throw new NotImplementedException();
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}

		public PropertyDescriptorCollection GetProperties()
		{
			throw new NotImplementedException();
		}

		public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			throw new NotImplementedException();
		}

		public object GetPropertyOwner(PropertyDescriptor pd)
		{
			throw new NotImplementedException();
		}
	}
}
