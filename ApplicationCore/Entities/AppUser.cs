using ApplicationCore.Entities;

namespace Infrastructure.NewFolder
{
    public class AppUser : BaseEntity<T>
    {
        public string Name{ get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Address { get; set; }
        public ICollection<BlogPost>? BlogPosts { get; set; }

    }
}
