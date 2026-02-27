using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_Forum.Models
{
    public class Tag
    {
        public int Id { get; private set; }
        public Post? Post { get; private set; }
        public Comment? Comment { get; private set; }

        // ctor
        // - Empty for EFC
        public Tag() { }

        // - For creating a new tag from a post
        public Tag(Post post)
        {
            Post = post ?? throw new ArgumentNullException(nameof(post));
        }

        // - For creating a new tag from a comment
        public Tag(Comment comment)
        {
            Comment = comment ?? throw new ArgumentNullException(nameof(comment));
        }
    }
}
