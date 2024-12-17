using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cloud.Model;

[Table("user")]
public class User {
    [Key]
    public int IdUser { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}