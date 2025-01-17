// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum WindowsAutopilotDeviceDeletionState.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum WindowsAutopilotDeviceDeletionState
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Failed
        /// </summary>
        Failed = 1,
	
        /// <summary>
        /// Accepted
        /// </summary>
        Accepted = 2,
	
        /// <summary>
        /// Error
        /// </summary>
        Error = 3,
	
    }
}
