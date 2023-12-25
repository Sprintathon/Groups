using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class ApplicationUser : BaseModel
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AvatarUrl { get; set; }

        // Navigation Properties
        public virtual ICollection<Group> Groups { get; set; }
    }
}
