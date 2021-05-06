// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Media.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<Media>))]
    public partial class Media
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Media"/> class.
        /// </summary>
        public Media()
        {
        }

        /// <summary>
        /// Gets or sets calleeDevice.
        /// Device information associated with the callee endpoint of this media.
        /// </summary>
        [JsonPropertyName("calleeDevice")]
        public DeviceInfo CalleeDevice { get; set; }
    
        /// <summary>
        /// Gets or sets calleeNetwork.
        /// Network information associated with the callee endpoint of this media.
        /// </summary>
        [JsonPropertyName("calleeNetwork")]
        public NetworkInfo CalleeNetwork { get; set; }
    
        /// <summary>
        /// Gets or sets callerDevice.
        /// Device information associated with the caller endpoint of this media.
        /// </summary>
        [JsonPropertyName("callerDevice")]
        public DeviceInfo CallerDevice { get; set; }
    
        /// <summary>
        /// Gets or sets callerNetwork.
        /// Network information associated with the caller endpoint of this media.
        /// </summary>
        [JsonPropertyName("callerNetwork")]
        public NetworkInfo CallerNetwork { get; set; }
    
        /// <summary>
        /// Gets or sets label.
        /// How the media was identified during media negotiation stage.
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }
    
        /// <summary>
        /// Gets or sets streams.
        /// Network streams associated with this media.
        /// </summary>
        [JsonPropertyName("streams")]
        public IEnumerable<MediaStream> Streams { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
