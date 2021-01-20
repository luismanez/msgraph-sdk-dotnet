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
    /// The type ShiftItem.
    /// </summary>
    public partial class ShiftItem : ScheduleEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShiftItem"/> class.
        /// </summary>
        public ShiftItem()
        {
            this.ODataType = "microsoft.graph.shiftItem";
        }

        /// <summary>
        /// Gets or sets activities.
        /// An incremental part of a shift which can cover details of when and where an employee is during their shift. For example, an assignment or a scheduled break or lunch. Required.
        /// </summary>
        [JsonPropertyName("activities")]
        public IEnumerable<ShiftActivity> Activities { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// The shift label of the shiftItem.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets notes.
        /// The shift notes for the shiftItem.
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes { get; set; }
    
    }
}
