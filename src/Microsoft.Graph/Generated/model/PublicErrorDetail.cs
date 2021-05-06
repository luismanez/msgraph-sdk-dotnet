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
    /// The type PublicErrorDetail.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PublicErrorDetail>))]
    public partial class PublicErrorDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicErrorDetail"/> class.
        /// </summary>
        public PublicErrorDetail()
        {
        }

        /// <summary>
        /// Gets or sets code.
        /// The error code.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }
    
        /// <summary>
        /// Gets or sets message.
        /// The error message.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    
        /// <summary>
        /// Gets or sets target.
        /// The target of the error.
        /// </summary>
        [JsonPropertyName("target")]
        public string Target { get; set; }
    
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
