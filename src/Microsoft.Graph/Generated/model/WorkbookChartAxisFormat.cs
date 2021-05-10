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
    /// The type Workbook Chart Axis Format.
    /// </summary>
    public partial class WorkbookChartAxisFormat : Entity
    {
    
        ///<summary>
        /// The WorkbookChartAxisFormat constructor
        ///</summary>
        public WorkbookChartAxisFormat()
        {
        }

        /// <summary>
        /// Gets or sets font.
        /// Represents the font attributes (font name, font size, color, etc.) for a chart axis element. Read-only.
        /// </summary>
        [JsonPropertyName("font")]
        public WorkbookChartFont Font { get; set; }
    
        /// <summary>
        /// Gets or sets line.
        /// Represents chart line formatting. Read-only.
        /// </summary>
        [JsonPropertyName("line")]
        public WorkbookChartLineFormat Line { get; set; }
    
    }
}

