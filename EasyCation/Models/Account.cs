using System.ComponentModel.DataAnnotations;

namespace EasyCation.Models;

public class Account
{
    public int Id { get; set; }
    public string Username { get; set; }
    [MaxLength(257)] public string Password { get; set; }
    public DateTime UserCreatedAt { get; set; } = DateTime.Now;
}