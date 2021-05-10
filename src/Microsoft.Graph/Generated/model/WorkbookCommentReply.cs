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
    /// The type Workbook Comment Reply.
    /// </summary>
    public partial class WorkbookCommentReply : Entity
    {
    
        ///<summary>
        /// The WorkbookCommentReply constructor
        ///</summary>
        public WorkbookCommentReply()
        {
        }

        /// <summary>
        /// Gets or sets content.
        /// The content of a comment reply.
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    
        /// <summary>
        /// Gets or sets content type.
        /// Indicates the type for the comment reply.
        /// </summary>
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }
    
    }
}

