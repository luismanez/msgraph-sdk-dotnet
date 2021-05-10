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
    /// The type Onenote Resource.
    /// </summary>
    public partial class OnenoteResource : OnenoteEntityBaseModel
    {
    
        ///<summary>
        /// The OnenoteResource constructor
        ///</summary>
        public OnenoteResource()
        {
        }

        /// <summary>
        /// Gets or sets content.
        /// The content stream
        /// </summary>
        [JsonPropertyName("content")]
        public Stream Content { get; set; }
    
        /// <summary>
        /// Gets or sets content url.
        /// The URL for downloading the content
        /// </summary>
        [JsonPropertyName("contentUrl")]
        public string ContentUrl { get; set; }
    
    }
}

