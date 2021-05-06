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
    /// The type AppliedConditionalAccessPolicy.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AppliedConditionalAccessPolicy>))]
    public partial class AppliedConditionalAccessPolicy
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppliedConditionalAccessPolicy"/> class.
        /// </summary>
        public AppliedConditionalAccessPolicy()
        {
        }

        /// <summary>
        /// Gets or sets displayName.
        /// Refers to the Name of the conditional access policy (example: 'Require MFA for Salesforce').
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enforcedGrantControls.
        /// Refers to the grant controls enforced by the conditional access policy (example: 'Require multi-factor authentication').
        /// </summary>
        [JsonPropertyName("enforcedGrantControls")]
        public IEnumerable<string> EnforcedGrantControls { get; set; }
    
        /// <summary>
        /// Gets or sets enforcedSessionControls.
        /// Refers to the session controls enforced by the conditional access policy (example: 'Require app enforced controls').
        /// </summary>
        [JsonPropertyName("enforcedSessionControls")]
        public IEnumerable<string> EnforcedSessionControls { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// Identifier of the conditional access policy.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets result.
        /// Indicates the result of the CA policy that was triggered. Possible values are: success, failure, notApplied (Policy isn't applied because policy conditions were not met),notEnabled (This is due to the policy in disabled state), unknown, unknownFutureValue, reportOnlySuccess, reportOnlyFailure, reportOnlyNotApplied, reportOnlyInterrupted
        /// </summary>
        [JsonPropertyName("result")]
        public AppliedConditionalAccessPolicyResult? Result { get; set; }
    
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
