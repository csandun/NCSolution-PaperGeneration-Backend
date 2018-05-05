using NCS.PaperGeneration.Entities.CommonEntities;
using NCS.PaperGeneration.Entities.CompactEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCS.PaperGeneration.Entities.Entities
{
    public class LoginUser : AuditableEntity<int>
    {
        public string Email { get; set; }
        public string LoginUserName { get; set; }
        public int PhoneNumber { get; set; }
        public string NIC { get; set; }
        public string Password { get; set; }
    }
}
