// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    [PersistableModelProxy(typeof(UnknownCustomAlertRule))]
    public partial class CustomAlertRule : IUtf8JsonSerializable, IJsonModel<CustomAlertRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomAlertRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomAlertRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomAlertRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomAlertRule)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("isEnabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("ruleType"u8);
            writer.WriteStringValue(RuleType);
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

        CustomAlertRule IJsonModel<CustomAlertRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomAlertRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomAlertRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomAlertRule(document.RootElement, options);
        }

        internal static CustomAlertRule DeserializeCustomAlertRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("ruleType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ActiveConnectionsNotInAllowedRange": return ActiveConnectionsNotInAllowedRange.DeserializeActiveConnectionsNotInAllowedRange(element, options);
                    case "AllowlistCustomAlertRule": return AllowlistCustomAlertRule.DeserializeAllowlistCustomAlertRule(element, options);
                    case "AmqpC2DMessagesNotInAllowedRange": return AmqpC2DMessagesNotInAllowedRange.DeserializeAmqpC2DMessagesNotInAllowedRange(element, options);
                    case "AmqpC2DRejectedMessagesNotInAllowedRange": return AmqpC2DRejectedMessagesNotInAllowedRange.DeserializeAmqpC2DRejectedMessagesNotInAllowedRange(element, options);
                    case "AmqpD2CMessagesNotInAllowedRange": return AmqpD2CMessagesNotInAllowedRange.DeserializeAmqpD2CMessagesNotInAllowedRange(element, options);
                    case "ConnectionFromIpNotAllowed": return ConnectionFromIPNotAllowed.DeserializeConnectionFromIPNotAllowed(element, options);
                    case "ConnectionToIpNotAllowed": return ConnectionToIPNotAllowed.DeserializeConnectionToIPNotAllowed(element, options);
                    case "DenylistCustomAlertRule": return DenylistCustomAlertRule.DeserializeDenylistCustomAlertRule(element, options);
                    case "DirectMethodInvokesNotInAllowedRange": return DirectMethodInvokesNotInAllowedRange.DeserializeDirectMethodInvokesNotInAllowedRange(element, options);
                    case "FailedLocalLoginsNotInAllowedRange": return FailedLocalLoginsNotInAllowedRange.DeserializeFailedLocalLoginsNotInAllowedRange(element, options);
                    case "FileUploadsNotInAllowedRange": return FileUploadsNotInAllowedRange.DeserializeFileUploadsNotInAllowedRange(element, options);
                    case "HttpC2DMessagesNotInAllowedRange": return HttpC2DMessagesNotInAllowedRange.DeserializeHttpC2DMessagesNotInAllowedRange(element, options);
                    case "HttpC2DRejectedMessagesNotInAllowedRange": return HttpC2DRejectedMessagesNotInAllowedRange.DeserializeHttpC2DRejectedMessagesNotInAllowedRange(element, options);
                    case "HttpD2CMessagesNotInAllowedRange": return HttpD2CMessagesNotInAllowedRange.DeserializeHttpD2CMessagesNotInAllowedRange(element, options);
                    case "ListCustomAlertRule": return ListCustomAlertRule.DeserializeListCustomAlertRule(element, options);
                    case "LocalUserNotAllowed": return LocalUserNotAllowed.DeserializeLocalUserNotAllowed(element, options);
                    case "MqttC2DMessagesNotInAllowedRange": return MqttC2DMessagesNotInAllowedRange.DeserializeMqttC2DMessagesNotInAllowedRange(element, options);
                    case "MqttC2DRejectedMessagesNotInAllowedRange": return MqttC2DRejectedMessagesNotInAllowedRange.DeserializeMqttC2DRejectedMessagesNotInAllowedRange(element, options);
                    case "MqttD2CMessagesNotInAllowedRange": return MqttD2CMessagesNotInAllowedRange.DeserializeMqttD2CMessagesNotInAllowedRange(element, options);
                    case "ProcessNotAllowed": return ProcessNotAllowed.DeserializeProcessNotAllowed(element, options);
                    case "QueuePurgesNotInAllowedRange": return QueuePurgesNotInAllowedRange.DeserializeQueuePurgesNotInAllowedRange(element, options);
                    case "ThresholdCustomAlertRule": return ThresholdCustomAlertRule.DeserializeThresholdCustomAlertRule(element, options);
                    case "TimeWindowCustomAlertRule": return TimeWindowCustomAlertRule.DeserializeTimeWindowCustomAlertRule(element, options);
                    case "TwinUpdatesNotInAllowedRange": return TwinUpdatesNotInAllowedRange.DeserializeTwinUpdatesNotInAllowedRange(element, options);
                    case "UnauthorizedOperationsNotInAllowedRange": return UnauthorizedOperationsNotInAllowedRange.DeserializeUnauthorizedOperationsNotInAllowedRange(element, options);
                }
            }
            return UnknownCustomAlertRule.DeserializeUnknownCustomAlertRule(element, options);
        }

        BinaryData IPersistableModel<CustomAlertRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomAlertRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomAlertRule)} does not support writing '{options.Format}' format.");
            }
        }

        CustomAlertRule IPersistableModel<CustomAlertRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomAlertRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCustomAlertRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomAlertRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomAlertRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
