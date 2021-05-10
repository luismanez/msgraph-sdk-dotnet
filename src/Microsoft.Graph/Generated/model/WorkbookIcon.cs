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
    /// The type WorkbookIcon.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WorkbookIcon>))]
    public partial class WorkbookIcon
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkbookIcon"/> class.
        /// </summary>
        public WorkbookIcon()
        {
        }

        /// <summary>
        /// Gets or sets index.
        /// Represents the index of the icon in the given set.
        /// </summary>
        [JsonPropertyName("index")]
        public Int32? Index { get; set; }
    
        /// <summary>
        /// Gets or sets set.
        /// Represents the set that the icon is part of. The possible values are: Invalid, ThreeArrows, ThreeArrowsGray, ThreeFlags, ThreeTrafficLights1, ThreeTrafficLights2, ThreeSigns, ThreeSymbols, ThreeSymbols2, FourArrows, FourArrowsGray, FourRedToBlack, FourRating, FourTrafficLights, FiveArrows, FiveArrowsGray, FiveRating, FiveQuarters, ThreeStars, ThreeTriangles, FiveBoxes.
        /// </summary>
        [JsonPropertyName("set")]
        public string Set { get; set; }
    
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
