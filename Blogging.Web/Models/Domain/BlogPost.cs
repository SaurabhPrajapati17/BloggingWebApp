namespace Blogging.Web.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public String Heading { get; set; }
        public String PageTitle { get; set; }
        public String Content { get; set; }
        public String ShortDiscription { get; set; }
        public String FeaturedImageUrl { get; set; }
        public String UrlHandle { get; set; }
        public DateTime PublishDate { get; set; }
        public String Author { get; set; }
        public bool IsVisible { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
