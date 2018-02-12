using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TS.BLL;
using TS.DAL;
using TS.DTO.Classes;

namespace TS.UI.Controllers
{
    public class FuncionarioController : Controller
    {

        readonly FuncionarioBLL _funcionarioBll = new FuncionarioBLL();
        readonly FuncionarioDAL _funcionarioDal = new FuncionarioDAL();
        readonly Context _context = new Context();

        // GET: Funcionario
        public ActionResult Index()
        {
            return View(_funcionarioDal.GetAll().ToList());
        }

        // GET: Funcionario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcionario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Funcionario funcionario)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(funcionario);
                }

                var u = funcionario.Usuario;
                var usu = new UsuarioController();
                usu.Create(u);

                _funcionarioBll.Insert(funcionario);


                TempData["Success"] = "Adicionado com sucesso!";

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Edit/5
        public ActionResult Edit(int id)
        {
            Funcionario func = _funcionarioDal.GetById(id);

            return View(func);
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Funcionario funcionario)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(funcionario);
                }

                _funcionarioBll.Update(funcionario);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/Delete/5
        public ActionResult Delete(int id)
        {
            _funcionarioBll.Delete(id);

            return RedirectToAction("Index");
        }

        // POST: Funcionario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}