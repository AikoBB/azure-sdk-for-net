// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.TimeZones
{
    public partial class TimeTransition
    {
        internal static TimeTransition DeserializeTimeTransition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string tag = default;
            string standardOffset = default;
            string daylightSavings = default;
            DateTimeOffset? utcStart = default;
            DateTimeOffset? utcEnd = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Tag"u8))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("StandardOffset"u8))
                {
                    standardOffset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DaylightSavings"u8))
                {
                    daylightSavings = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("UtcStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    utcStart = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("UtcEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    utcEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new TimeTransition(tag, standardOffset, daylightSavings, utcStart, utcEnd);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TimeTransition FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTimeTransition(document.RootElement);
        }
    }
}
