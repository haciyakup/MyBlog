using System;
using System.ComponentModel.DataAnnotations;

namespace My_Blog_MVC.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
    }

    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "User name (*)")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your name...")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "The length of name must be in 3-30.")]
        [Display(Name = "First Name (*)")]
        public string memberName { get; set; }

        [Required(ErrorMessage = "Please enter your surname...")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "The length of surname must be in 3-30.")]
        [Display(Name = "Surname (*)")]
        public string memberSurname { get; set; }

        [Required(ErrorMessage = "Please enter your e-mail address...")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter valid e-mail address.")]
        [Display(Name = "E-mail Address (*)")]
        public string e_mail { set; get; }

        [StringLength(30, MinimumLength = 3, ErrorMessage = "The length of country name must be in 3-30.")]
        [Display(Name = "Country")]
        public string memberCountry { get; set; }

        public DateTime becomeMemberDate { get { return DateTime.Now; } }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password (*)")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password (*)")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
