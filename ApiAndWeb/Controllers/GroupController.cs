namespace ApiAndWeb.Controllers
{
    public class GroupController : BaseController<Group>
    {
        public GroupController(ApplicationDbContext context) : base(context)
        {
        }
    }
}
