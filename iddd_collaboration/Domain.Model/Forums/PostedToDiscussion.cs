﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaaSOvation.Common.Domain;
using SaaSOvation.Collaboration.Domain.Model.Tenants;
using SaaSOvation.Collaboration.Domain.Model.Collaborators;

namespace SaaSOvation.Collaboration.Domain.Model.Forums
{
    public class PostedToDiscussion : IDomainEvent
    {
        public PostedToDiscussion(Tenant tenantId, ForumId forumId, DiscussionId discussionId, PostId postId, Author author, string subject, string bodyText, PostId replyToPostId)
        {
            this.TenantId = tenantId;
            this.ForumId = forumId;
            this.DiscussionId = discussionId;
            this.PostId = postId;
            this.Author = author;
            this.Subject = subject;
            this.BodyText = bodyText;
            this.ReplyToPostId = replyToPostId;
        }

        public Tenant TenantId { get; private set; }
        public ForumId ForumId { get; private set; }
        public DiscussionId DiscussionId { get; private set; }
        public PostId PostId { get; private set; }
        public Author Author { get; private set; }
        public string Subject { get; private set; }
        public string BodyText { get; private set; }
        public PostId ReplyToPostId { get; private set; }

        public int EventVersion { get; set; }
        public DateTime OccurredOn { get; set; }
    }
}
