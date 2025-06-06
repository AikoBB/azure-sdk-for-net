// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class TransferOffersResult : IUtf8JsonSerializable, IJsonModel<TransferOffersResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TransferOffersResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TransferOffersResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferOffersResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransferOffersResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Succeeded))
            {
                writer.WritePropertyName("succeeded"u8);
                writer.WriteStartArray();
                foreach (var item in Succeeded)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Failed))
            {
                writer.WritePropertyName("failed"u8);
                writer.WriteStartArray();
                foreach (var item in Failed)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
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

        TransferOffersResult IJsonModel<TransferOffersResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferOffersResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransferOffersResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTransferOffersResult(document.RootElement, options);
        }

        internal static TransferOffersResult DeserializeTransferOffersResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<PrivateStoreCollectionDetails> succeeded = default;
            IReadOnlyList<PrivateStoreCollectionDetails> failed = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("succeeded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateStoreCollectionDetails> array = new List<PrivateStoreCollectionDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateStoreCollectionDetails.DeserializePrivateStoreCollectionDetails(item, options));
                    }
                    succeeded = array;
                    continue;
                }
                if (property.NameEquals("failed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateStoreCollectionDetails> array = new List<PrivateStoreCollectionDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateStoreCollectionDetails.DeserializePrivateStoreCollectionDetails(item, options));
                    }
                    failed = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TransferOffersResult(succeeded ?? new ChangeTrackingList<PrivateStoreCollectionDetails>(), failed ?? new ChangeTrackingList<PrivateStoreCollectionDetails>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TransferOffersResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferOffersResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TransferOffersResult)} does not support writing '{options.Format}' format.");
            }
        }

        TransferOffersResult IPersistableModel<TransferOffersResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferOffersResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTransferOffersResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TransferOffersResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TransferOffersResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
