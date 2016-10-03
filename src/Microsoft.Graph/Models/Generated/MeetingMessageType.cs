// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.



namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum MeetingMessageType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum MeetingMessageType
    {
    
        /// <summary>
        /// none
        /// </summary>
        None,
    
        /// <summary>
        /// meeting Request
        /// </summary>
        MeetingRequest,
    
        /// <summary>
        /// meeting Cancelled
        /// </summary>
        MeetingCancelled,
    
        /// <summary>
        /// meeting Accepted
        /// </summary>
        MeetingAccepted,
    
        /// <summary>
        /// meeting Tenatively Accepted
        /// </summary>
        MeetingTenativelyAccepted,
    
        /// <summary>
        /// meeting Declined
        /// </summary>
        MeetingDeclined,
    
    }
}
