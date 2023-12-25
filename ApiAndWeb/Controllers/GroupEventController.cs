namespace ApiAndWeb.Controllers
{
    public class GroupEventController : BaseController<GroupEvent>
    {
        public GroupEventController(ApplicationDbContext context) : base(context)
        {
        }
    }
}
