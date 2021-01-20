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
    /// The type Education School.
    /// </summary>
    public partial class EducationSchool : EducationOrganization
    {
    
		///<summary>
		/// The EducationSchool constructor
		///</summary>
        public EducationSchool()
        {
            this.ODataType = "microsoft.graph.educationSchool";
        }
	
        /// <summary>
        /// Gets or sets address.
        /// Address of the school.
        /// </summary>
        [JsonPropertyName("address")]
        public PhysicalAddress Address { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// Entity who created the school.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets external id.
        /// ID of school in syncing system.
        /// </summary>
        [JsonPropertyName("externalId")]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or sets external principal id.
        /// ID of principal in syncing system.
        /// </summary>
        [JsonPropertyName("externalPrincipalId")]
        public string ExternalPrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets fax.
        /// </summary>
        [JsonPropertyName("fax")]
        public string Fax { get; set; }
    
        /// <summary>
        /// Gets or sets highest grade.
        /// Highest grade taught.
        /// </summary>
        [JsonPropertyName("highestGrade")]
        public string HighestGrade { get; set; }
    
        /// <summary>
        /// Gets or sets lowest grade.
        /// Lowest grade taught.
        /// </summary>
        [JsonPropertyName("lowestGrade")]
        public string LowestGrade { get; set; }
    
        /// <summary>
        /// Gets or sets phone.
        /// Phone number of school.
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    
        /// <summary>
        /// Gets or sets principal email.
        /// Email address of the principal.
        /// </summary>
        [JsonPropertyName("principalEmail")]
        public string PrincipalEmail { get; set; }
    
        /// <summary>
        /// Gets or sets principal name.
        /// Name of the principal.
        /// </summary>
        [JsonPropertyName("principalName")]
        public string PrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets school number.
        /// School Number.
        /// </summary>
        [JsonPropertyName("schoolNumber")]
        public string SchoolNumber { get; set; }
    
        /// <summary>
        /// Gets or sets classes.
        /// Classes taught at the school. Nullable.
        /// </summary>
        [JsonPropertyName("classes")]
        public IEducationSchoolClassesCollectionWithReferencesPage Classes { get; set; }
    
        /// <summary>
        /// Gets or sets users.
        /// Users in the school. Nullable.
        /// </summary>
        [JsonPropertyName("users")]
        public IEducationSchoolUsersCollectionWithReferencesPage Users { get; set; }
    
    }
}

