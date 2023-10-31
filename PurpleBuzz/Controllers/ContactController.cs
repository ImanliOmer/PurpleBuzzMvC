using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.DAL;
using PurpleBuzz.ViewModels.Contact;

namespace PurpleBuzz.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var createSuccesse = _context.createSuccessesses.FirstOrDefault();


            var model = new ContactIndexVM
            {
                CreateSuccesse = createSuccesse
            };

            return View();
        }
    }
}
