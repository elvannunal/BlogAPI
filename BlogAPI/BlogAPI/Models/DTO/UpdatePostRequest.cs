namespace BlogAPI.Models.DTO;

public class UpdatePostRequest
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string UrlHandle { get; set; }
    public string FeaturedImageUrl { get; set; }
    public bool Visible { get; set; }
    public string Author { get; set; }
}