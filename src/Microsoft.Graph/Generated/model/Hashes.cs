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
    /// The type Hashes.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Hashes>))]
    public partial class Hashes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hashes"/> class.
        /// </summary>
        public Hashes()
        {
        }

        /// <summary>
        /// Gets or sets crc32Hash.
        /// The CRC32 value of the file in little endian (if available). Read-only.
        /// </summary>
        [JsonPropertyName("crc32Hash")]
        public string Crc32Hash { get; set; }
    
        /// <summary>
        /// Gets or sets quickXorHash.
        /// A proprietary hash of the file that can be used to determine if the contents of the file have changed (if available). Read-only.
        /// </summary>
        [JsonPropertyName("quickXorHash")]
        public string QuickXorHash { get; set; }
    
        /// <summary>
        /// Gets or sets sha1Hash.
        /// SHA1 hash for the contents of the file (if available). Read-only.
        /// </summary>
        [JsonPropertyName("sha1Hash")]
        public string Sha1Hash { get; set; }
    
        /// <summary>
        /// Gets or sets sha256Hash.
        /// SHA256 hash for the contents of the file (if available). Read-only.
        /// </summary>
        [JsonPropertyName("sha256Hash")]
        public string Sha256Hash { get; set; }
    
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
