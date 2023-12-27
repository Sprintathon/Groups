namespace ApiAndWeb.Controllers
{
    [AllowAnonymous]
    public class GroupController : BaseController<Group>
    {
        public GroupController(ApplicationDbContext context) : base(context)
        {
        }
    }
}
