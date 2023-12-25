namespace ApiAndWeb.Controllers
{
    public class EventScheduleController : BaseController<EventSchedule>
    {
        public EventScheduleController(ApplicationDbContext context) : base(context)
        {
        }
    }
}
