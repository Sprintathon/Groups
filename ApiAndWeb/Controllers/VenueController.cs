namespace ApiAndWeb.Controllers
{
    public class VenueController : BaseController<Venue>
    {
        public VenueController(ApplicationDbContext context) : base(context)
        {
        }
    }
}
