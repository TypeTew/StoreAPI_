namespace StoreAPI.Models;

public static class UserRoles
{
    public static readonly string Admin = "Admin";
    public static readonly string User = "User";
    public static string? Manager { get; internal set; }
}