﻿namespace ApiAndWeb.Controllers
{
    [AllowAnonymous]
    public class VenueController : BaseController<Venue>
    {
        public VenueController(ApplicationDbContext context) : base(context)
        {
        }
    }
}
