using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TS.DAL;
using TS.UI.Models;

namespace TS.UI.Controllers
{
    public class LoginController : Controller
    {
        readonly Context _context = new Context();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logar([FromForm]LoginViewModel user)
        {

            if (_context.Usuarios.Any(u => u.Login == user.Login
                                          && u.Senha == user.Senha))
            {


                return RedirectToAction("Filtrar");

            }


            return RedirectToAction("Index");

        }



        public ActionResult Filtrar()
        {

            var tipo = (from u in _context.Usuarios
                        select u.Tipo.Id);

            if (tipo.First() != 1)
            {
                ViewBag.Func = "Funcionario:";
                return Redirect("/Funcionario/Index");


            }
            ViewBag.Adm = "Administrador";
            
            return Redirect("/Adm/Index");

        }
    }
}