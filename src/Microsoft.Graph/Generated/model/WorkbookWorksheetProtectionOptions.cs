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
    /// The type WorkbookWorksheetProtectionOptions.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WorkbookWorksheetProtectionOptions>))]
    public partial class WorkbookWorksheetProtectionOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkbookWorksheetProtectionOptions"/> class.
        /// </summary>
        public WorkbookWorksheetProtectionOptions()
        {
        }

        /// <summary>
        /// Gets or sets allowAutoFilter.
        /// Represents the worksheet protection option of allowing using auto filter feature.
        /// </summary>
        [JsonPropertyName("allowAutoFilter")]
        public bool? AllowAutoFilter { get; set; }
    
        /// <summary>
        /// Gets or sets allowDeleteColumns.
        /// Represents the worksheet protection option of allowing deleting columns.
        /// </summary>
        [JsonPropertyName("allowDeleteColumns")]
        public bool? AllowDeleteColumns { get; set; }
    
        /// <summary>
        /// Gets or sets allowDeleteRows.
        /// Represents the worksheet protection option of allowing deleting rows.
        /// </summary>
        [JsonPropertyName("allowDeleteRows")]
        public bool? AllowDeleteRows { get; set; }
    
        /// <summary>
        /// Gets or sets allowFormatCells.
        /// Represents the worksheet protection option of allowing formatting cells.
        /// </summary>
        [JsonPropertyName("allowFormatCells")]
        public bool? AllowFormatCells { get; set; }
    
        /// <summary>
        /// Gets or sets allowFormatColumns.
        /// Represents the worksheet protection option of allowing formatting columns.
        /// </summary>
        [JsonPropertyName("allowFormatColumns")]
        public bool? AllowFormatColumns { get; set; }
    
        /// <summary>
        /// Gets or sets allowFormatRows.
        /// Represents the worksheet protection option of allowing formatting rows.
        /// </summary>
        [JsonPropertyName("allowFormatRows")]
        public bool? AllowFormatRows { get; set; }
    
        /// <summary>
        /// Gets or sets allowInsertColumns.
        /// Represents the worksheet protection option of allowing inserting columns.
        /// </summary>
        [JsonPropertyName("allowInsertColumns")]
        public bool? AllowInsertColumns { get; set; }
    
        /// <summary>
        /// Gets or sets allowInsertHyperlinks.
        /// Represents the worksheet protection option of allowing inserting hyperlinks.
        /// </summary>
        [JsonPropertyName("allowInsertHyperlinks")]
        public bool? AllowInsertHyperlinks { get; set; }
    
        /// <summary>
        /// Gets or sets allowInsertRows.
        /// Represents the worksheet protection option of allowing inserting rows.
        /// </summary>
        [JsonPropertyName("allowInsertRows")]
        public bool? AllowInsertRows { get; set; }
    
        /// <summary>
        /// Gets or sets allowPivotTables.
        /// Represents the worksheet protection option of allowing using pivot table feature.
        /// </summary>
        [JsonPropertyName("allowPivotTables")]
        public bool? AllowPivotTables { get; set; }
    
        /// <summary>
        /// Gets or sets allowSort.
        /// Represents the worksheet protection option of allowing using sort feature.
        /// </summary>
        [JsonPropertyName("allowSort")]
        public bool? AllowSort { get; set; }
    
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
