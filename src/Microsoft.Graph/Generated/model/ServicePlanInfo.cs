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
    /// The type ServicePlanInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ServicePlanInfo>))]
    public partial class ServicePlanInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePlanInfo"/> class.
        /// </summary>
        public ServicePlanInfo()
        {
        }

        /// <summary>
        /// Gets or sets appliesTo.
        /// The object the service plan can be assigned to. Possible values:'User' - service plan can be assigned to individual users.'Company' - service plan can be assigned to the entire tenant.
        /// </summary>
        [JsonPropertyName("appliesTo")]
        public string AppliesTo { get; set; }
    
        /// <summary>
        /// Gets or sets provisioningStatus.
        /// The provisioning status of the service plan. Possible values:'Success' - Service is fully provisioned.'Disabled' - Service has been disabled.'PendingInput' - Service is not yet provisioned; awaiting service confirmation.'PendingActivation' - Service is provisioned but requires explicit activation by administrator (for example, Intune_O365 service plan)'PendingProvisioning' - Microsoft has added a new service to the product SKU and it has not been activated in the tenant, yet.
        /// </summary>
        [JsonPropertyName("provisioningStatus")]
        public string ProvisioningStatus { get; set; }
    
        /// <summary>
        /// Gets or sets servicePlanId.
        /// The unique identifier of the service plan.
        /// </summary>
        [JsonPropertyName("servicePlanId")]
        public Guid? ServicePlanId { get; set; }
    
        /// <summary>
        /// Gets or sets servicePlanName.
        /// The name of the service plan.
        /// </summary>
        [JsonPropertyName("servicePlanName")]
        public string ServicePlanName { get; set; }
    
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
