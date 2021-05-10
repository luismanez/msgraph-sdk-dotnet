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
    /// The type Drive Item Version.
    /// </summary>
    public partial class DriveItemVersion : BaseItemVersion
    {
    
        ///<summary>
        /// The DriveItemVersion constructor
        ///</summary>
        public DriveItemVersion()
        {
        }

        /// <summary>
        /// Gets or sets content.
        /// The content stream for this version of the item.
        /// </summary>
        [JsonPropertyName("content")]
        public Stream Content { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// Indicates the size of the content stream for this version of the item.
        /// </summary>
        [JsonPropertyName("size")]
        public Int64? Size { get; set; }
    
    }
}

