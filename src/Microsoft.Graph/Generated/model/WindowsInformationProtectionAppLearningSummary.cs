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
    /// The type Windows Information Protection App Learning Summary.
    /// </summary>
    public partial class WindowsInformationProtectionAppLearningSummary : Entity
    {
    
        ///<summary>
        /// The WindowsInformationProtectionAppLearningSummary constructor
        ///</summary>
        public WindowsInformationProtectionAppLearningSummary()
        {
        }

        /// <summary>
        /// Gets or sets application name.
        /// Application Name
        /// </summary>
        [JsonPropertyName("applicationName")]
        public string ApplicationName { get; set; }
    
        /// <summary>
        /// Gets or sets application type.
        /// Application Type. Possible values are: universal, desktop.
        /// </summary>
        [JsonPropertyName("applicationType")]
        public ApplicationType? ApplicationType { get; set; }
    
        /// <summary>
        /// Gets or sets device count.
        /// Device Count
        /// </summary>
        [JsonPropertyName("deviceCount")]
        public Int32? DeviceCount { get; set; }
    
    }
}

