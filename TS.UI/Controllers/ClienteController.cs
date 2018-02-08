using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TS.BLL;
using TS.DAL;
using TS.DTO.Classes;

namespace TS.UI.Controllers
{
    public class ClienteController : Controller
    {
        readonly ClienteBLL _clienteBll = new ClienteBLL();
        readonly ClienteDAL _clienteDal = new ClienteDAL();

        // GET: Cliente
        public ActionResult Index()
        {   
            
            return View(_clienteDal.GetAll().ToList());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(cliente);
                }
                _clienteBll.Insert(cliente);
                TempData["Success"] = "Adicionado com sucesso!";

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            Cliente cliente = _clienteDal.GetById(id);

            return View(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cliente cliente)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(cliente);
                }

                _clienteBll.Update(cliente);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}