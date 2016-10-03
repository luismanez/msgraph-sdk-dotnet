// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsBinom_DistRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsBinom_DistRequestBody
    {
    
        /// <summary>
        /// Gets or sets NumberS.
        /// </summary>
        [DataMember(Name = "numberS", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken NumberS { get; set; }
    
        /// <summary>
        /// Gets or sets Trials.
        /// </summary>
        [DataMember(Name = "trials", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Trials { get; set; }
    
        /// <summary>
        /// Gets or sets ProbabilityS.
        /// </summary>
        [DataMember(Name = "probabilityS", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken ProbabilityS { get; set; }
    
        /// <summary>
        /// Gets or sets Cumulative.
        /// </summary>
        [DataMember(Name = "cumulative", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Cumulative { get; set; }
    
    }
}
