using Infrastructure.NewFolder;

namespace ApplicationCore.Entities
{
    public class BlogPost
    {
        public int BlogPostId { get; set; }
        public string? BlogTitle { get; set; }
        public string? BlogContent { get; set; }
        public DateTime CreatedAt { get; set; }

        public int UserId { get; set; }
        public AppUser User { get; set; }

        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Tag>? Tags { get; set; }

    }
}
