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
    /// The type Thumbnail.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Thumbnail>))]
    public partial class Thumbnail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Thumbnail"/> class.
        /// </summary>
        public Thumbnail()
        {
        }

        /// <summary>
        /// Gets or sets content.
        /// The content stream for the thumbnail.
        /// </summary>
        [JsonPropertyName("content")]
        public Stream Content { get; set; }
    
        /// <summary>
        /// Gets or sets height.
        /// The height of the thumbnail, in pixels.
        /// </summary>
        [JsonPropertyName("height")]
        public Int32? Height { get; set; }
    
        /// <summary>
        /// Gets or sets sourceItemId.
        /// The unique identifier of the item that provided the thumbnail. This is only available when a folder thumbnail is requested.
        /// </summary>
        [JsonPropertyName("sourceItemId")]
        public string SourceItemId { get; set; }
    
        /// <summary>
        /// Gets or sets url.
        /// The URL used to fetch the thumbnail content.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
        /// <summary>
        /// Gets or sets width.
        /// The width of the thumbnail, in pixels.
        /// </summary>
        [JsonPropertyName("width")]
        public Int32? Width { get; set; }
    
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
