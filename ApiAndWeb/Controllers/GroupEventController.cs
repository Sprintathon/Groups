namespace ApiAndWeb.Controllers
{
    [AllowAnonymous]
    public class GroupEventController : BaseController<GroupEvent>
    {
        public GroupEventController(ApplicationDbContext context) : base(context)
        {
        }
    }
}
