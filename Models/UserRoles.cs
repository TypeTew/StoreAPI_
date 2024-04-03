namespace StoreAPI.Models;

public class UserRoles
{
    public const string Admin = "Admin";
    public const string User = "User";
    public static string Manager { get; internal set; }
}