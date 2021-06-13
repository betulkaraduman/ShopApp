using System.ComponentModel.DataAnnotations;

namespace ShopApp.webui.Models
{
    public class ResetPasswordModel
    {
        [Required]
        public string Token { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }    
        [Required]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

    }
}