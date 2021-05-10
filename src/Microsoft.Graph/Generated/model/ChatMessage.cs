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
    /// The type Chat Message.
    /// </summary>
    public partial class ChatMessage : Entity
    {
    
        ///<summary>
        /// The ChatMessage constructor
        ///</summary>
        public ChatMessage()
        {
        }

        /// <summary>
        /// Gets or sets attachments.
        /// Attached files. Attachments are currently read-only – sending attachments is not supported.
        /// </summary>
        [JsonPropertyName("attachments")]
        public IEnumerable<ChatMessageAttachment> Attachments { get; set; }
    
        /// <summary>
        /// Gets or sets body.
        /// Plaintext/HTML representation of the content of the chat message. Representation is specified by the contentType inside the body. The content is always in HTML if the chat message contains a chatMessageMention.
        /// </summary>
        [JsonPropertyName("body")]
        public ItemBody Body { get; set; }
    
        /// <summary>
        /// Gets or sets channel identity.
        /// If the message was sent in a channel, represents identity of the channel.
        /// </summary>
        [JsonPropertyName("channelIdentity")]
        public ChannelIdentity ChannelIdentity { get; set; }
    
        /// <summary>
        /// Gets or sets chat id.
        /// If the message was sent in a chat, represents the identity of the chat.
        /// </summary>
        [JsonPropertyName("chatId")]
        public string ChatId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Timestamp of when the chat message was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets deleted date time.
        /// Read only. Timestamp at which the chat message was deleted, or null if not deleted.
        /// </summary>
        [JsonPropertyName("deletedDateTime")]
        public DateTimeOffset? DeletedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets etag.
        /// Read-only. Version number of the chat message.
        /// </summary>
        [JsonPropertyName("etag")]
        public string Etag { get; set; }
    
        /// <summary>
        /// Gets or sets from.
        /// Read only. Details of the sender of the chat message.
        /// </summary>
        [JsonPropertyName("from")]
        public IdentitySet From { get; set; }
    
        /// <summary>
        /// Gets or sets importance.
        /// The importance of the chat message. The possible values are: normal, high, urgent.
        /// </summary>
        [JsonPropertyName("importance")]
        public ChatMessageImportance? Importance { get; set; }
    
        /// <summary>
        /// Gets or sets last edited date time.
        /// Read only. Timestamp when edits to the chat message were made. Triggers an 'Edited' flag in the Teams UI. If no edits are made the value is null.
        /// </summary>
        [JsonPropertyName("lastEditedDateTime")]
        public DateTimeOffset? LastEditedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Read only. Timestamp when the chat message is created (initial setting) or modified, including when a reaction is added or removed.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets locale.
        /// Locale of the chat message set by the client. Always set to en-us.
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale { get; set; }
    
        /// <summary>
        /// Gets or sets mentions.
        /// List of entities mentioned in the chat message. Currently supports user, bot, team, channel.
        /// </summary>
        [JsonPropertyName("mentions")]
        public IEnumerable<ChatMessageMention> Mentions { get; set; }
    
        /// <summary>
        /// Gets or sets message type.
        /// The type of chat message. The possible value is: message.
        /// </summary>
        [JsonPropertyName("messageType")]
        public ChatMessageType? MessageType { get; set; }
    
        /// <summary>
        /// Gets or sets policy violation.
        /// Defines the properties of a policy violation set by a data loss prevention (DLP) application.
        /// </summary>
        [JsonPropertyName("policyViolation")]
        public ChatMessagePolicyViolation PolicyViolation { get; set; }
    
        /// <summary>
        /// Gets or sets reactions.
        /// Reactions for this chat message (for example, Like).
        /// </summary>
        [JsonPropertyName("reactions")]
        public IEnumerable<ChatMessageReaction> Reactions { get; set; }
    
        /// <summary>
        /// Gets or sets reply to id.
        /// Read-only. Id of the parent chat message or root chat message of the thread. (Only applies to chat messages in channels, not chats.)
        /// </summary>
        [JsonPropertyName("replyToId")]
        public string ReplyToId { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// The subject of the chat message, in plaintext.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets summary.
        /// Summary text of the chat message that could be used for push notifications and summary views or fall back views. Only applies to channel chat messages, not chat messages in a chat.
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary { get; set; }
    
        /// <summary>
        /// Gets or sets web url.
        /// Read-only. Link to the message in Microsoft Teams.
        /// </summary>
        [JsonPropertyName("webUrl")]
        public string WebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets hosted contents.
        /// Content in a message hosted by Microsoft Teams e.g., images, code snippets etc.
        /// </summary>
        [JsonPropertyName("hostedContents")]
        public IChatMessageHostedContentsCollectionPage HostedContents { get; set; }

        /// <summary>
        /// Gets or sets hostedContentsNextLink.
        /// </summary>
        [JsonPropertyName("hostedContents@odata.nextLink")]
        public string HostedContentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets replies.
        /// Replies for a specified message.
        /// </summary>
        [JsonPropertyName("replies")]
        public IChatMessageRepliesCollectionPage Replies { get; set; }

        /// <summary>
        /// Gets or sets repliesNextLink.
        /// </summary>
        [JsonPropertyName("replies@odata.nextLink")]
        public string RepliesNextLink { get; set; }
    
    }
}

