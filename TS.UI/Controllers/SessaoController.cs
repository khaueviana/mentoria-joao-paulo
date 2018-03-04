using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
                if (!ModelState.IsValid)
                {
                    return View(sessao);
                }

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
            ViewBag.ClienteId = new SelectList(_clienteDal.GetAll(), "Id", "Nome");
            ViewBag.FormaPagamentoId = new SelectList(_pagamentoDal.GetAll(), "Id", "Descricao");
            return View();
        }

        // POST: Sessao/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Sessao sessao, int clienteId, int formaPagamentoId)
        {

            ViewBag.ClienteId = new SelectList(_clienteDal.GetAll(), "Id", "Nome");
            ViewBag.FormaPagamentoId = new SelectList(_pagamentoDal.GetAll(), "Id", "Descricao");

            try
            {
                if (!ModelState.IsValid)
                {
                    return View(sessao);
                }

                _sessaoBll.Update(sessao, clienteId, formaPagamentoId);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.InnerException;
                return View();
            }
        }

        // GET: Sessao/Delete/5
        public ActionResult Delete(int id)
        {
            _sessaoBll.Delete(id);
            return RedirectToAction("Index");
        }

      
    }
}