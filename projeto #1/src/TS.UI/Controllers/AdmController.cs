using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite.Internal.UrlActions;

namespace TS.UI.Controllers
{
    public class AdmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cliente()
        {
            return RedirectToAction("Create", "Cliente");
        }

        public IActionResult Funcionario()
        {
            return RedirectToAction("Create", "Funcionario");
        }

        public IActionResult Sair()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}