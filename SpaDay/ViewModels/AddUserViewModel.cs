using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 15 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20,MinimumLength =6,ErrorMessage = "Password must be betweeen 6 to 20 characters.")]
        public string Password { get; set; }

        [CompareAttribute("Password",ErrorMessage ="The password and verify password fields do not match.")]
        public string VerifyPassword { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
    }
}
