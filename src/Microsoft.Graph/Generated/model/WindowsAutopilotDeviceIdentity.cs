// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Windows Autopilot Device Identity.
    /// </summary>
    public partial class WindowsAutopilotDeviceIdentity : Entity
    {
    
        ///<summary>
        /// The WindowsAutopilotDeviceIdentity constructor
        ///</summary>
        public WindowsAutopilotDeviceIdentity()
        {
        }

        /// <summary>
        /// Gets or sets addressable user name.
        /// Addressable user name.
        /// </summary>
        [JsonPropertyName("addressableUserName")]
        public string AddressableUserName { get; set; }
    
        /// <summary>
        /// Gets or sets azure active directory device id.
        /// AAD Device ID - to be deprecated
        /// </summary>
        [JsonPropertyName("azureActiveDirectoryDeviceId")]
        public string AzureActiveDirectoryDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display Name
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment state.
        /// Intune enrollment state of the Windows autopilot device. Possible values are: unknown, enrolled, pendingReset, failed, notContacted, blocked.
        /// </summary>
        [JsonPropertyName("enrollmentState")]
        public EnrollmentState? EnrollmentState { get; set; }
    
        /// <summary>
        /// Gets or sets group tag.
        /// Group Tag of the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("groupTag")]
        public string GroupTag { get; set; }
    
        /// <summary>
        /// Gets or sets last contacted date time.
        /// Intune Last Contacted Date Time of the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("lastContactedDateTime")]
        public DateTimeOffset? LastContactedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets managed device id.
        /// Managed Device ID
        /// </summary>
        [JsonPropertyName("managedDeviceId")]
        public string ManagedDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// Oem manufacturer of the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// Model name of the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets product key.
        /// Product Key of the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("productKey")]
        public string ProductKey { get; set; }
    
        /// <summary>
        /// Gets or sets purchase order identifier.
        /// Purchase Order Identifier of the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("purchaseOrderIdentifier")]
        public string PurchaseOrderIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets resource name.
        /// Resource Name.
        /// </summary>
        [JsonPropertyName("resourceName")]
        public string ResourceName { get; set; }
    
        /// <summary>
        /// Gets or sets serial number.
        /// Serial number of the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("serialNumber")]
        public string SerialNumber { get; set; }
    
        /// <summary>
        /// Gets or sets sku number.
        /// SKU Number
        /// </summary>
        [JsonPropertyName("skuNumber")]
        public string SkuNumber { get; set; }
    
        /// <summary>
        /// Gets or sets system family.
        /// System Family
        /// </summary>
        [JsonPropertyName("systemFamily")]
        public string SystemFamily { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User Principal Name.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
    }
}

