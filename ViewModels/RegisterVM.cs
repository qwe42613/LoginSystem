using System.ComponentModel.DataAnnotations;

namespace LoginSystem.ViewModels
{
  public class RegisterVM
  {
    public string? Name { get; set; }
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }
    [DataType(DataType.Password)]
    public string? Password { get; set; }
    [Compare("Password", ErrorMessage = "Password don't match.")]
    [Display(Name = "Confirm Password")]
    public string? ConfirmPassword { get; set; }
    public string? Address { get; set; }
  }
}
