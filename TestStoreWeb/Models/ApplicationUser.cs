using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TestStoreWeb.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        public string fullName { get; set; }
        public string? Address { get; set; }
        public string? Voucher { get; set; }
        public string? Membership { get; set; }


    }
}
