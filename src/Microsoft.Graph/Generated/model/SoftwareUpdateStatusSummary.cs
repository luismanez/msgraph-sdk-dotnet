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
    /// The type Software Update Status Summary.
    /// </summary>
    public partial class SoftwareUpdateStatusSummary : Entity
    {
    
		///<summary>
		/// The SoftwareUpdateStatusSummary constructor
		///</summary>
        public SoftwareUpdateStatusSummary()
        {
            this.ODataType = "microsoft.graph.softwareUpdateStatusSummary";
        }
	
        /// <summary>
        /// Gets or sets compliant device count.
        /// Number of compliant devices.
        /// </summary>
        [JsonPropertyName("compliantDeviceCount")]
        public Int32? CompliantDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets compliant user count.
        /// Number of compliant users.
        /// </summary>
        [JsonPropertyName("compliantUserCount")]
        public Int32? CompliantUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets conflict device count.
        /// Number of conflict devices.
        /// </summary>
        [JsonPropertyName("conflictDeviceCount")]
        public Int32? ConflictDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets conflict user count.
        /// Number of conflict users.
        /// </summary>
        [JsonPropertyName("conflictUserCount")]
        public Int32? ConflictUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name of the policy.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets error device count.
        /// Number of devices had error.
        /// </summary>
        [JsonPropertyName("errorDeviceCount")]
        public Int32? ErrorDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets error user count.
        /// Number of users had error.
        /// </summary>
        [JsonPropertyName("errorUserCount")]
        public Int32? ErrorUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets non compliant device count.
        /// Number of non compliant devices.
        /// </summary>
        [JsonPropertyName("nonCompliantDeviceCount")]
        public Int32? NonCompliantDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets non compliant user count.
        /// Number of non compliant users.
        /// </summary>
        [JsonPropertyName("nonCompliantUserCount")]
        public Int32? NonCompliantUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets not applicable device count.
        /// Number of not applicable devices.
        /// </summary>
        [JsonPropertyName("notApplicableDeviceCount")]
        public Int32? NotApplicableDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets not applicable user count.
        /// Number of not applicable users.
        /// </summary>
        [JsonPropertyName("notApplicableUserCount")]
        public Int32? NotApplicableUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets remediated device count.
        /// Number of remediated devices.
        /// </summary>
        [JsonPropertyName("remediatedDeviceCount")]
        public Int32? RemediatedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets remediated user count.
        /// Number of remediated users.
        /// </summary>
        [JsonPropertyName("remediatedUserCount")]
        public Int32? RemediatedUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets unknown device count.
        /// Number of unknown devices.
        /// </summary>
        [JsonPropertyName("unknownDeviceCount")]
        public Int32? UnknownDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets unknown user count.
        /// Number of unknown users.
        /// </summary>
        [JsonPropertyName("unknownUserCount")]
        public Int32? UnknownUserCount { get; set; }
    
    }
}

