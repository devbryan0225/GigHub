using GigHub.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class ArtistsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtistsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Following()
        {
            var userId = User.Identity.GetUserId();

            var followings = _context.Followings.Where(f => f.FollowerId == userId).Select(f => f.Followee).ToList();

            return View(followings);
        }
    }
}