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
    /// The type WorkbookFunctionsRateRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsRateRequestBody
    {
    
        /// <summary>
        /// Gets or sets Nper.
        /// </summary>
        [DataMember(Name = "nper", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Nper { get; set; }
    
        /// <summary>
        /// Gets or sets Pmt.
        /// </summary>
        [DataMember(Name = "pmt", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Pmt { get; set; }
    
        /// <summary>
        /// Gets or sets Pv.
        /// </summary>
        [DataMember(Name = "pv", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Pv { get; set; }
    
        /// <summary>
        /// Gets or sets Fv.
        /// </summary>
        [DataMember(Name = "fv", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Fv { get; set; }
    
        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Type { get; set; }
    
        /// <summary>
        /// Gets or sets Guess.
        /// </summary>
        [DataMember(Name = "guess", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Guess { get; set; }
    
    }
}
