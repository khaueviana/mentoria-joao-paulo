using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
using Microsoft.EntityFrameworkCore;
using TS.BLL;
using TS.DAL;
using TS.DTO.Classes;

namespace TS.UI.Controllers
{
    public class SessaoController : Controller
    {

        readonly ClienteDAL _clienteDal = new ClienteDAL();
        readonly SessaoBLL _sessaoBll = new SessaoBLL();
        readonly PagamentoDAL _pagamentoDal = new PagamentoDAL();
        readonly SessaoDAL _sessaoDal = new SessaoDAL();
        

        // GET: Sessao
        public ActionResult Index()
        {
           
            return View(_sessaoDal.GetAll().ToList());
        }

        // GET: Sessao/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sessao/Create
        public ActionResult Create()
        {

            ViewBag.ClienteId = new SelectList(_clienteDal.GetAll(), "Id", "Nome");
            ViewBag.FormaPagamentoId = new SelectList(_pagamentoDal.GetAll(), "Id", "Descricao");
            return View();
        }

        // POST: Sessao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Sessao sessao, int clienteId, int formaPagamentoId)
        {
            ViewBag.ClienteId = new SelectList(_clienteDal.GetAll(), "Id", "Nome");
            ViewBag.FormaPagamentoId = new SelectList(_pagamentoDal.GetAll(), "Id", "Descricao");
            try
            {
                _sessaoBll.Insert(sessao, clienteId, formaPagamentoId);
                TempData["Success"] = "Adicionado com sucesso!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.InnerException.Message;
                return View();
            }



        }

        // GET: Sessao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sessao/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Sessao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sessao/Delete/5
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