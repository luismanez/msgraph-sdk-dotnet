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
    /// The type Device Compliance Policy Device State Summary.
    /// </summary>
    public partial class DeviceCompliancePolicyDeviceStateSummary : Entity
    {
    
        ///<summary>
        /// The DeviceCompliancePolicyDeviceStateSummary constructor
        ///</summary>
        public DeviceCompliancePolicyDeviceStateSummary()
        {
        }

        /// <summary>
        /// Gets or sets compliant device count.
        /// Number of compliant devices
        /// </summary>
        [JsonPropertyName("compliantDeviceCount")]
        public Int32? CompliantDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets config manager count.
        /// Number of devices that have compliance managed by System Center Configuration Manager
        /// </summary>
        [JsonPropertyName("configManagerCount")]
        public Int32? ConfigManagerCount { get; set; }
    
        /// <summary>
        /// Gets or sets conflict device count.
        /// Number of conflict devices
        /// </summary>
        [JsonPropertyName("conflictDeviceCount")]
        public Int32? ConflictDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets error device count.
        /// Number of error devices
        /// </summary>
        [JsonPropertyName("errorDeviceCount")]
        public Int32? ErrorDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets in grace period count.
        /// Number of devices that are in grace period
        /// </summary>
        [JsonPropertyName("inGracePeriodCount")]
        public Int32? InGracePeriodCount { get; set; }
    
        /// <summary>
        /// Gets or sets non compliant device count.
        /// Number of NonCompliant devices
        /// </summary>
        [JsonPropertyName("nonCompliantDeviceCount")]
        public Int32? NonCompliantDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets not applicable device count.
        /// Number of not applicable devices
        /// </summary>
        [JsonPropertyName("notApplicableDeviceCount")]
        public Int32? NotApplicableDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets remediated device count.
        /// Number of remediated devices
        /// </summary>
        [JsonPropertyName("remediatedDeviceCount")]
        public Int32? RemediatedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets unknown device count.
        /// Number of unknown devices
        /// </summary>
        [JsonPropertyName("unknownDeviceCount")]
        public Int32? UnknownDeviceCount { get; set; }
    
    }
}

