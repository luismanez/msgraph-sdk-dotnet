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
    /// The type Multi Value Legacy Extended Property.
    /// </summary>
    public partial class MultiValueLegacyExtendedProperty : Entity
    {
    
		///<summary>
		/// The MultiValueLegacyExtendedProperty constructor
		///</summary>
        public MultiValueLegacyExtendedProperty()
        {
            this.ODataType = "microsoft.graph.multiValueLegacyExtendedProperty";
        }
	
        /// <summary>
        /// Gets or sets value.
        /// A collection of property values.
        /// </summary>
        [JsonPropertyName("value")]
        public IEnumerable<string> Value { get; set; }
    
    }
}

