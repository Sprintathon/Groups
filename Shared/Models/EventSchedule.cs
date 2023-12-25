using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class EventSchedule : BaseModel
    {
        // Properties
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Description { get; set; }

        // Navigation Properties
        public int VenueId { get; set; }
        public virtual Venue Venue { get; set; }
        public int GroupEventId { get; set; }
        public virtual GroupEvent GroupEvent { get; set; }
    }
}
