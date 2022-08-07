using System.ComponentModel.DataAnnotations.Schema;

namespace fr.pierrejulien.ddit.api.Models;

[Table("reddits")]
public class Reddit
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; init; }

    [Column("picture")]
    public string Picture { get; init; }

    [Column("followers")]
    public int Followers { get; init; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}
