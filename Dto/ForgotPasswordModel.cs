using System.ComponentModel.DataAnnotations;

namespace INVENTORY.SHARED.Dto
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string To { get; set; }
    }
}
