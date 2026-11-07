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
using System.Reflection;
using System.Runtime.Serialization;

namespace Transmitly.ChannelProvider.Twilio.Configuration
{
	internal static class EnumUtil
	{
		/// <summary>
		/// Finds the member whose <see cref="EnumMemberAttribute"/> value matches; <see langword="null"/> when missing or unknown.
		/// </summary>
		public static T? ToEnum<T>(string? value) where T : struct, Enum
		{
			if (string.IsNullOrWhiteSpace(value))
				return null;

			foreach (var name in Enum.GetNames(typeof(T)))
			{
				var attr = typeof(T).GetRuntimeField(name)?.GetCustomAttribute<EnumMemberAttribute>(true);
				if (attr != null && attr.Value == value)
					return (T)Enum.Parse(typeof(T), name);
			}

			return null;
		}
	}
}
