using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebFormContact.Models;

namespace WebFormContact.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Submit(ContactViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Mensajes = _context.ContactMessages.ToList();
                return View("Index", model);

            }
            _context.ContactMessages.Add(model.NuevoMensaje);
            _context.SaveChanges();

            TempData["SuccessMessage"] = "Tu mensaje ha sido enviado con éxito.";
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var viewModel = new ContactViewModel
            {
                NuevoMensaje = new ContactMessage(),
                Mensajes = _context.ContactMessages.ToList()
            };
            return View(viewModel);
        } 
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
