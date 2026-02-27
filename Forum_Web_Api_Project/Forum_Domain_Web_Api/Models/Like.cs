using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_Forum.Models
{
    public class Like
    {
        public int Id { get; private set; }
        public Post? Post { get; private set; }
        public Comment? Comment { get; private set; }

        // True = Is liked, False = Is disliked
        public bool IsLiked { get; private set; }

        // ctor
        // - Empty for EFC
        public Like() { }

        // - For creating a new like from a post   
        public Like(Post post, bool isLiked = true)
        {
            Post = post ?? throw new ArgumentNullException(nameof(post));
            IsLiked = isLiked;
        }

        // - For creating a new like from a comment
        public Like(Comment comment, bool isLiked = true)
        {
            Comment = comment ?? throw new ArgumentNullException(nameof(comment));
            IsLiked = isLiked;
        }
    }
}
