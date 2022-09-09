using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTORY.SHARED.Model
{
    public class User : IdentityUser
    {
        [NotMapped]
        public string Password { get; set; }
        public ERole Role { get; set; }
        public bool IsActive { get; set; }
    }
}
