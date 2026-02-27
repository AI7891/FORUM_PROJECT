namespace Domain_Forum.Models
{
    public class Post
    {
        #region Properties
        public int Id { get; private set; }
        public Member MemberId { get; private set; }

        public DateTime CreationDate { get; private set; } = DateTime.Now;
        public string Subject { get; private set; }

        public string Body { get; private set; } = string.Empty;

        public IEnumerable<Comment> Comments { get; private set; } = [];
        public IEnumerable<Like> Likes { get; private set; } = [];

        public IEnumerable<Tag> Tags { get; private set; } = [];
        #endregion

        #region Builders
        public Post()
        {

        }

        public Post( Member member, string subject, string body, IEnumerable<Comment> comments, IEnumerable<Like> likes, IEnumerable<Tag> tags)
        {
            if (member is null)
            {
                throw new ArgumentNullException("L'utilisateur n'existe pas");
            }

            MemberId = member;
            Subject = subject;
            Body = body;
            Comments = comments ?? Enumerable.Empty<Comment>();
            Likes = likes ?? Enumerable.Empty<Like>();
            Tags = tags ?? Enumerable.Empty<Tag>();
        }

        public Post(int id, Member member, string subject, string body, IEnumerable<Comment> comments, IEnumerable<Like> likes, IEnumerable<Tag> tags)
        : this( member, subject, body, comments, likes, tags)
        {
            Id = id;
        }
        #endregion
    }
}
