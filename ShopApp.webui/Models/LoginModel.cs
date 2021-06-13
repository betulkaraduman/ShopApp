using System.ComponentModel.DataAnnotations;

namespace ShopApp.webui.Models
{
    public class LoginModel
    {
        [Required]
        public string Email{get;set;}
        // public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}