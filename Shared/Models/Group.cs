using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Group : BaseModel
    {
        // Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public string AvatarUrl { get; set; }

        // Navigation Properties
        public virtual List<ApplicationUser> Users { get; set; }
        public virtual List<GroupEvent> Events { get; set; }
    }
}
