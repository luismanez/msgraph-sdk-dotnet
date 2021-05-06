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
    /// The type Location.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Location>))]
    public partial class Location
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        public Location()
        {
        }

        /// <summary>
        /// Gets or sets address.
        /// The street address of the location.
        /// </summary>
        [JsonPropertyName("address")]
        public PhysicalAddress Address { get; set; }
    
        /// <summary>
        /// Gets or sets coordinates.
        /// The geographic coordinates and elevation of the location.
        /// </summary>
        [JsonPropertyName("coordinates")]
        public OutlookGeoCoordinates Coordinates { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// The name associated with the location.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets locationEmailAddress.
        /// Optional email address of the location.
        /// </summary>
        [JsonPropertyName("locationEmailAddress")]
        public string LocationEmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets locationType.
        /// The type of location. Possible values are: default, conferenceRoom, homeAddress, businessAddress,geoCoordinates, streetAddress, hotel, restaurant, localBusiness, postalAddress. Read-only.
        /// </summary>
        [JsonPropertyName("locationType")]
        public LocationType? LocationType { get; set; }
    
        /// <summary>
        /// Gets or sets locationUri.
        /// Optional URI representing the location.
        /// </summary>
        [JsonPropertyName("locationUri")]
        public string LocationUri { get; set; }
    
        /// <summary>
        /// Gets or sets uniqueId.
        /// For internal use only.
        /// </summary>
        [JsonPropertyName("uniqueId")]
        public string UniqueId { get; set; }
    
        /// <summary>
        /// Gets or sets uniqueIdType.
        /// For internal use only.
        /// </summary>
        [JsonPropertyName("uniqueIdType")]
        public LocationUniqueIdType? UniqueIdType { get; set; }
    
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
