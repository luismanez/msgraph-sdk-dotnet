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
    /// The type Shift Preferences.
    /// </summary>
    public partial class ShiftPreferences : ChangeTrackedEntity
    {
    
        ///<summary>
        /// The ShiftPreferences constructor
        ///</summary>
        public ShiftPreferences()
        {
        }

        /// <summary>
        /// Gets or sets availability.
        /// Availability of the user to be scheduled for work and its recurrence pattern.
        /// </summary>
        [JsonPropertyName("availability")]
        public IEnumerable<ShiftAvailability> Availability { get; set; }
    
    }
}

