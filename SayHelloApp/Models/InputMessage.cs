using System.ComponentModel.DataAnnotations;

namespace SayHelloApp.Models;
public class InputName
{
    [Required]
    public string? Name { get; set; }
}
