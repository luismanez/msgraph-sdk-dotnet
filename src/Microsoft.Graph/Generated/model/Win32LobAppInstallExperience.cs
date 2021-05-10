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
    /// The type Win32LobAppInstallExperience.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Win32LobAppInstallExperience>))]
    public partial class Win32LobAppInstallExperience
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Win32LobAppInstallExperience"/> class.
        /// </summary>
        public Win32LobAppInstallExperience()
        {
        }

        /// <summary>
        /// Gets or sets deviceRestartBehavior.
        /// Device restart behavior. Possible values are: basedOnReturnCode, allow, suppress, force.
        /// </summary>
        [JsonPropertyName("deviceRestartBehavior")]
        public Win32LobAppRestartBehavior? DeviceRestartBehavior { get; set; }
    
        /// <summary>
        /// Gets or sets runAsAccount.
        /// Indicates the type of execution context the app runs in. Possible values are: system, user.
        /// </summary>
        [JsonPropertyName("runAsAccount")]
        public RunAsAccountType? RunAsAccount { get; set; }
    
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
