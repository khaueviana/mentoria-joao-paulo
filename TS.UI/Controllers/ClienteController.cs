using System;
using System.Linq;
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
            catch(Exception ex)
            {
                TempData["Error"] = ex.Message;
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
            catch(Exception ex)
            {
                TempData["Error"] = ex.InnerException;
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            _clienteBll.Delete(id);

            return RedirectToAction("Index");
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConf(int id)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                TempData["Error"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

    }
}