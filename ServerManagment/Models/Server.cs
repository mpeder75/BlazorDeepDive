using System.ComponentModel.DataAnnotations;

namespace ServerManagment.Models;

public class Server
{
    public int ServerId { get; set; }
    public bool IsOnline { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? City { get; set; }

    public Server()
    {
        var random = new Random();
        var randomNumber = random.Next(0, 2);
        IsOnline = randomNumber == 0 ? false : true;
    }
}