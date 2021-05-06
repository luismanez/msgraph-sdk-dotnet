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
    /// The type ParentalControlSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ParentalControlSettings>))]
    public partial class ParentalControlSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParentalControlSettings"/> class.
        /// </summary>
        public ParentalControlSettings()
        {
        }

        /// <summary>
        /// Gets or sets countriesBlockedForMinors.
        /// Specifies the two-letter ISO country codes. Access to the application will be blocked for minors from the countries specified in this list.
        /// </summary>
        [JsonPropertyName("countriesBlockedForMinors")]
        public IEnumerable<string> CountriesBlockedForMinors { get; set; }
    
        /// <summary>
        /// Gets or sets legalAgeGroupRule.
        /// Specifies the legal age group rule that applies to users of the app. Can be set to one of the following values: ValueDescriptionAllowDefault. Enforces the legal minimum. This means parental consent is required for minors in the European Union and Korea.RequireConsentForPrivacyServicesEnforces the user to specify date of birth to comply with COPPA rules. RequireConsentForMinorsRequires parental consent for ages below 18, regardless of country minor rules.RequireConsentForKidsRequires parental consent for ages below 14, regardless of country minor rules.BlockMinorsBlocks minors from using the app.
        /// </summary>
        [JsonPropertyName("legalAgeGroupRule")]
        public string LegalAgeGroupRule { get; set; }
    
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
