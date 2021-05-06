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
    /// The type Workbook Chart Gridlines.
    /// </summary>
    public partial class WorkbookChartGridlines : Entity
    {
    
        ///<summary>
        /// The WorkbookChartGridlines constructor
        ///</summary>
        public WorkbookChartGridlines()
        {
        }

        /// <summary>
        /// Gets or sets visible.
        /// Boolean value representing if the axis gridlines are visible or not.
        /// </summary>
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// Represents the formatting of chart gridlines. Read-only.
        /// </summary>
        [JsonPropertyName("format")]
        public WorkbookChartGridlinesFormat Format { get; set; }
    
    }
}

