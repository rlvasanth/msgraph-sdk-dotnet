// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GroupConversationsCollectionRequestBuilder.
    /// </summary>
    public partial class GroupConversationsCollectionRequestBuilder : BaseRequestBuilder, IGroupConversationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GroupConversationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupConversationsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGroupConversationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGroupConversationsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GroupConversationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IConversationRequestBuilder"/> for the specified GroupConversation.
        /// </summary>
        /// <param name="id">The ID for the GroupConversation.</param>
        /// <returns>The <see cref="IConversationRequestBuilder"/>.</returns>
        public IConversationRequestBuilder this[string id]
        {
            get
            {
                return new ConversationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
