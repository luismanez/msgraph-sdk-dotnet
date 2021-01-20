// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type WorkbookFilterApplyCustomFilterRequestBody.
    /// </summary>
    public partial class WorkbookFilterApplyCustomFilterRequestBody
    {
    
        /// <summary>
        /// Gets or sets Criteria1.
        /// </summary>
        [JsonPropertyName("criteria1")]
        public string Criteria1 { get; set; }
    
        /// <summary>
        /// Gets or sets Criteria2.
        /// </summary>
        [JsonPropertyName("criteria2")]
        public string Criteria2 { get; set; }
    
        /// <summary>
        /// Gets or sets Oper.
        /// </summary>
        [JsonPropertyName("oper")]
        public string Oper { get; set; }
    
    }
}
