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
    /// The type Windows Information Protection Network Learning Summary.
    /// </summary>
    public partial class WindowsInformationProtectionNetworkLearningSummary : Entity
    {
    
        ///<summary>
        /// The WindowsInformationProtectionNetworkLearningSummary constructor
        ///</summary>
        public WindowsInformationProtectionNetworkLearningSummary()
        {
        }

        /// <summary>
        /// Gets or sets device count.
        /// Device Count
        /// </summary>
        [JsonPropertyName("deviceCount")]
        public Int32? DeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets url.
        /// Website url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    }
}

