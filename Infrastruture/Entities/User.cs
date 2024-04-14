using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fainting.Infrastructure.Entities;

[Table("user")]
public partial class User
{
    [Key]
    [Column("userid")]
    public int UserId { get; set; }

    [Column("group_id")]
    public int? GroupId { get; set; }

    [Column("username")]
    public string Username { get; set; } = null!;

    [Column("fullname")]
    public string? Fullname { get; set; }

    [Column("email")]
    public string Email { get; set; } = null!;
    [Column("password")]
    public string Password { get; set; } = null!;

    [Column("mobile", TypeName = "text")]
    public string? Mobile { get; set; }
}
