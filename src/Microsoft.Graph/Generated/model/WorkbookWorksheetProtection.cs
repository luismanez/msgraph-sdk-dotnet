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
    /// The type Workbook Worksheet Protection.
    /// </summary>
    public partial class WorkbookWorksheetProtection : Entity
    {
    
        ///<summary>
        /// The WorkbookWorksheetProtection constructor
        ///</summary>
        public WorkbookWorksheetProtection()
        {
        }

        /// <summary>
        /// Gets or sets options.
        /// Sheet protection options. Read-only.
        /// </summary>
        [JsonPropertyName("options")]
        public WorkbookWorksheetProtectionOptions Options { get; set; }
    
        /// <summary>
        /// Gets or sets protected.
        /// Indicates if the worksheet is protected.  Read-only.
        /// </summary>
        [JsonPropertyName("protected")]
        public bool? Protected { get; set; }
    
    }
}

