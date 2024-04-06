using System.ComponentModel.DataAnnotations;

public class RegisterRoleModel
{
    [Required]
    [StringLength(256, ErrorMessage = "Role name cannot be longer than 256 characters.")]
    public string Role { get; set; }
}