// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class HyperVToAzStackHciNicInput : IUtf8JsonSerializable, IJsonModel<HyperVToAzStackHciNicInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVToAzStackHciNicInput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HyperVToAzStackHciNicInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciNicInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVToAzStackHciNicInput)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("nicId"u8);
            writer.WriteStringValue(NicId);
            if (options.Format != "W" && Optional.IsDefined(NetworkName))
            {
                writer.WritePropertyName("networkName"u8);
                writer.WriteStringValue(NetworkName);
            }
            writer.WritePropertyName("targetNetworkId"u8);
            writer.WriteStringValue(TargetNetworkId);
            writer.WritePropertyName("testNetworkId"u8);
            writer.WriteStringValue(TestNetworkId);
            writer.WritePropertyName("selectionTypeForFailover"u8);
            writer.WriteStringValue(SelectionTypeForFailover.ToString());
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        HyperVToAzStackHciNicInput IJsonModel<HyperVToAzStackHciNicInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciNicInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVToAzStackHciNicInput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVToAzStackHciNicInput(document.RootElement, options);
        }

        internal static HyperVToAzStackHciNicInput DeserializeHyperVToAzStackHciNicInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nicId = default;
            string networkName = default;
            string targetNetworkId = default;
            string testNetworkId = default;
            VmNicSelection selectionTypeForFailover = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nicId"u8))
                {
                    nicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkName"u8))
                {
                    networkName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetNetworkId"u8))
                {
                    targetNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testNetworkId"u8))
                {
                    testNetworkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectionTypeForFailover"u8))
                {
                    selectionTypeForFailover = new VmNicSelection(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HyperVToAzStackHciNicInput(
                nicId,
                networkName,
                targetNetworkId,
                testNetworkId,
                selectionTypeForFailover,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HyperVToAzStackHciNicInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciNicInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HyperVToAzStackHciNicInput)} does not support writing '{options.Format}' format.");
            }
        }

        HyperVToAzStackHciNicInput IPersistableModel<HyperVToAzStackHciNicInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVToAzStackHciNicInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHyperVToAzStackHciNicInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HyperVToAzStackHciNicInput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVToAzStackHciNicInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
