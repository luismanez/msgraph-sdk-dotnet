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
    /// The type Mac OSCustom Configuration.
    /// </summary>
    public partial class MacOSCustomConfiguration : DeviceConfiguration
    {
    
        ///<summary>
        /// The MacOSCustomConfiguration constructor
        ///</summary>
        public MacOSCustomConfiguration()
        {
            this.ODataType = "microsoft.graph.macOSCustomConfiguration";
        }
    
        /// <summary>
        /// Gets or sets payload.
        /// Payload. (UTF8 encoded byte array)
        /// </summary>
        [JsonPropertyName("payload")]
        public byte[] Payload { get; set; }
    
        /// <summary>
        /// Gets or sets payload file name.
        /// Payload file name (.mobileconfig | .xml).
        /// </summary>
        [JsonPropertyName("payloadFileName")]
        public string PayloadFileName { get; set; }
    
        /// <summary>
        /// Gets or sets payload name.
        /// Name that is displayed to the user.
        /// </summary>
        [JsonPropertyName("payloadName")]
        public string PayloadName { get; set; }
    
    }
}

