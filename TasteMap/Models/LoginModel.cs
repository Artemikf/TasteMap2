using System.ComponentModel.DataAnnotations;

namespace TasteMap.Models;

public class LoginModel
{
    [Required(ErrorMessage = "Email required")]
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password required")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }
}
