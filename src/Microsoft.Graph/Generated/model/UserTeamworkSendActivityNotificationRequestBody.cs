// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type UserTeamworkSendActivityNotificationRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UserTeamworkSendActivityNotificationRequestBody
    {
    
        /// <summary>
        /// Gets or sets Topic.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "topic", Required = Newtonsoft.Json.Required.Default)]
        public TeamworkActivityTopic Topic { get; set; }
    
        /// <summary>
        /// Gets or sets ActivityType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activityType", Required = Newtonsoft.Json.Required.Default)]
        public string ActivityType { get; set; }
    
        /// <summary>
        /// Gets or sets ChainId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "chainId", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ChainId { get; set; }
    
        /// <summary>
        /// Gets or sets PreviewText.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previewText", Required = Newtonsoft.Json.Required.Default)]
        public ItemBody PreviewText { get; set; }
    
        /// <summary>
        /// Gets or sets TemplateParameters.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "templateParameters", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> TemplateParameters { get; set; }
    
    }
}
