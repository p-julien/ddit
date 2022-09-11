namespace fr.pierrejulien.ddit.api.Models;

public class RedditModel
{
    public int Id { get; set; }
    public string Name { get; init; }
    public string Picture { get; init; }
    public int Followers { get; init; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
