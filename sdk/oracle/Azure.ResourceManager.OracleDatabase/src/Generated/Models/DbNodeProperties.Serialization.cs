// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    public partial class DbNodeProperties : IUtf8JsonSerializable, IJsonModel<DbNodeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DbNodeProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DbNodeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DbNodeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DbNodeProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("ocid"u8);
                writer.WriteStringValue(Ocid);
            }
            if (options.Format != "W" && Optional.IsDefined(AdditionalDetails))
            {
                writer.WritePropertyName("additionalDetails"u8);
                writer.WriteStringValue(AdditionalDetails);
            }
            if (options.Format != "W" && Optional.IsDefined(BackupIPId))
            {
                writer.WritePropertyName("backupIpId"u8);
                writer.WriteStringValue(BackupIPId);
            }
            if (options.Format != "W" && Optional.IsDefined(BackupVnic2Id))
            {
                writer.WritePropertyName("backupVnic2Id"u8);
                writer.WriteStringValue(BackupVnic2Id);
            }
            if (options.Format != "W" && Optional.IsDefined(BackupVnicId))
            {
                writer.WritePropertyName("backupVnicId"u8);
                writer.WriteStringValue(BackupVnicId);
            }
            if (options.Format != "W" && Optional.IsDefined(CpuCoreCount))
            {
                writer.WritePropertyName("cpuCoreCount"u8);
                writer.WriteNumberValue(CpuCoreCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DbNodeStorageSizeInGbs))
            {
                writer.WritePropertyName("dbNodeStorageSizeInGbs"u8);
                writer.WriteNumberValue(DbNodeStorageSizeInGbs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DbServerId))
            {
                writer.WritePropertyName("dbServerId"u8);
                writer.WriteStringValue(DbServerId);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("dbSystemId"u8);
                writer.WriteStringValue(DbSystemId);
            }
            if (options.Format != "W" && Optional.IsDefined(FaultDomain))
            {
                writer.WritePropertyName("faultDomain"u8);
                writer.WriteStringValue(FaultDomain);
            }
            if (options.Format != "W" && Optional.IsDefined(HostIPId))
            {
                writer.WritePropertyName("hostIpId"u8);
                writer.WriteStringValue(HostIPId);
            }
            if (options.Format != "W" && Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteStringValue(Hostname);
            }
            if (options.Format != "W" && Optional.IsDefined(LifecycleState))
            {
                writer.WritePropertyName("lifecycleState"u8);
                writer.WriteStringValue(LifecycleState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LifecycleDetails))
            {
                writer.WritePropertyName("lifecycleDetails"u8);
                writer.WriteStringValue(LifecycleDetails);
            }
            if (options.Format != "W" && Optional.IsDefined(MaintenanceType))
            {
                writer.WritePropertyName("maintenanceType"u8);
                writer.WriteStringValue(MaintenanceType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(MemorySizeInGbs))
            {
                writer.WritePropertyName("memorySizeInGbs"u8);
                writer.WriteNumberValue(MemorySizeInGbs.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SoftwareStorageSizeInGb))
            {
                writer.WritePropertyName("softwareStorageSizeInGb"u8);
                writer.WriteNumberValue(SoftwareStorageSizeInGb.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TimeCreated))
            {
                writer.WritePropertyName("timeCreated"u8);
                writer.WriteStringValue(TimeCreated.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(TimeMaintenanceWindowEnd))
            {
                writer.WritePropertyName("timeMaintenanceWindowEnd"u8);
                writer.WriteStringValue(TimeMaintenanceWindowEnd.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(TimeMaintenanceWindowStart))
            {
                writer.WritePropertyName("timeMaintenanceWindowStart"u8);
                writer.WriteStringValue(TimeMaintenanceWindowStart.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Vnic2Id))
            {
                writer.WritePropertyName("vnic2Id"u8);
                writer.WriteStringValue(Vnic2Id);
            }
            if (options.Format != "W" && Optional.IsDefined(VnicId))
            {
                writer.WritePropertyName("vnicId"u8);
                writer.WriteStringValue(VnicId);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DbNodeProperties IJsonModel<DbNodeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DbNodeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DbNodeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDbNodeProperties(document.RootElement, options);
        }

        internal static DbNodeProperties DeserializeDbNodeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ocid = default;
            string additionalDetails = default;
            string backupIPId = default;
            string backupVnic2Id = default;
            string backupVnicId = default;
            int? cpuCoreCount = default;
            int? dbNodeStorageSizeInGbs = default;
            string dbServerId = default;
            string dbSystemId = default;
            string faultDomain = default;
            string hostIPId = default;
            string hostname = default;
            DbNodeProvisioningState? lifecycleState = default;
            string lifecycleDetails = default;
            DbNodeMaintenanceType? maintenanceType = default;
            int? memorySizeInGbs = default;
            int? softwareStorageSizeInGb = default;
            DateTimeOffset? timeCreated = default;
            DateTimeOffset? timeMaintenanceWindowEnd = default;
            DateTimeOffset? timeMaintenanceWindowStart = default;
            string vnic2Id = default;
            string vnicId = default;
            ResourceProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ocid"u8))
                {
                    ocid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalDetails"u8))
                {
                    additionalDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupIpId"u8))
                {
                    backupIPId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupVnic2Id"u8))
                {
                    backupVnic2Id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupVnicId"u8))
                {
                    backupVnicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuCoreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuCoreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dbNodeStorageSizeInGbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dbNodeStorageSizeInGbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dbServerId"u8))
                {
                    dbServerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbSystemId"u8))
                {
                    dbSystemId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("faultDomain"u8))
                {
                    faultDomain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostIpId"u8))
                {
                    hostIPId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostname"u8))
                {
                    hostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lifecycleState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lifecycleState = new DbNodeProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lifecycleDetails"u8))
                {
                    lifecycleDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maintenanceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maintenanceType = new DbNodeMaintenanceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("memorySizeInGbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memorySizeInGbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("softwareStorageSizeInGb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softwareStorageSizeInGb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeCreated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeCreated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeMaintenanceWindowEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeMaintenanceWindowEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeMaintenanceWindowStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeMaintenanceWindowStart = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("vnic2Id"u8))
                {
                    vnic2Id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vnicId"u8))
                {
                    vnicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ResourceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DbNodeProperties(
                ocid,
                additionalDetails,
                backupIPId,
                backupVnic2Id,
                backupVnicId,
                cpuCoreCount,
                dbNodeStorageSizeInGbs,
                dbServerId,
                dbSystemId,
                faultDomain,
                hostIPId,
                hostname,
                lifecycleState,
                lifecycleDetails,
                maintenanceType,
                memorySizeInGbs,
                softwareStorageSizeInGb,
                timeCreated,
                timeMaintenanceWindowEnd,
                timeMaintenanceWindowStart,
                vnic2Id,
                vnicId,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DbNodeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DbNodeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DbNodeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DbNodeProperties IPersistableModel<DbNodeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DbNodeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDbNodeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DbNodeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DbNodeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
