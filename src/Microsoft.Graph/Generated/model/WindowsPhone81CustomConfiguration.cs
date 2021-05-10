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
    /// The type Windows Phone81Custom Configuration.
    /// </summary>
    public partial class WindowsPhone81CustomConfiguration : DeviceConfiguration
    {
    
        ///<summary>
        /// The WindowsPhone81CustomConfiguration constructor
        ///</summary>
        public WindowsPhone81CustomConfiguration()
        {
            this.ODataType = "microsoft.graph.windowsPhone81CustomConfiguration";
        }
    
        /// <summary>
        /// Gets or sets oma settings.
        /// OMA settings. This collection can contain a maximum of 1000 elements.
        /// </summary>
        [JsonPropertyName("omaSettings")]
        public IEnumerable<OmaSetting> OmaSettings { get; set; }
    
    }
}

