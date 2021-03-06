// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Conversation Thread.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ConversationThread : Entity
    {
    
        /// <summary>
        /// Gets or sets to recipients.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "toRecipients", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Recipient> ToRecipients { get; set; }
    
        /// <summary>
        /// Gets or sets topic.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "topic", Required = Newtonsoft.Json.Required.Default)]
        public string Topic { get; set; }
    
        /// <summary>
        /// Gets or sets has attachments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasAttachments", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets last delivered date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastDeliveredDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastDeliveredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets unique senders.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "uniqueSenders", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> UniqueSenders { get; set; }
    
        /// <summary>
        /// Gets or sets cc recipients.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ccRecipients", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Recipient> CcRecipients { get; set; }
    
        /// <summary>
        /// Gets or sets preview.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preview", Required = Newtonsoft.Json.Required.Default)]
        public string Preview { get; set; }
    
        /// <summary>
        /// Gets or sets is locked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isLocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsLocked { get; set; }
    
        /// <summary>
        /// Gets or sets posts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "posts", Required = Newtonsoft.Json.Required.Default)]
        public IConversationThreadPostsCollectionPage Posts { get; set; }
    
    }
}

