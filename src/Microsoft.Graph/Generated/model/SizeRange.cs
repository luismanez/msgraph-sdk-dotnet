// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type SizeRange.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SizeRange>))]
    public partial class SizeRange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SizeRange"/> class.
        /// </summary>
        public SizeRange()
        {
        }

        /// <summary>
        /// Gets or sets maximumSize.
        /// The maximum size (in kilobytes) that an incoming message must have in order for a condition or exception to apply.
        /// </summary>
        [JsonPropertyName("maximumSize")]
        public Int32? MaximumSize { get; set; }
    
        /// <summary>
        /// Gets or sets minimumSize.
        /// The minimum size (in kilobytes) that an incoming message must have in order for a condition or exception to apply.
        /// </summary>
        [JsonPropertyName("minimumSize")]
        public Int32? MinimumSize { get; set; }
    
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
