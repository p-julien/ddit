using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models;

[Table("users")]
public class User
{
    [Column("id")]
    public int Id { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [Column("name")]
    public string Name { get; set; }
}
