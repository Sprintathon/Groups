namespace ApiAndWeb.Controllers
{
    [AllowAnonymous]
    public class EventScheduleController : BaseController<EventSchedule>
    {
        public EventScheduleController(ApplicationDbContext context) : base(context)
        {
        }
    }
}
