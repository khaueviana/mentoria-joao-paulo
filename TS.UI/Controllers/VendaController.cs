using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Rotativa;
using TS.BLL;
using TS.DAL;

namespace TS.UI.Controllers
{
    public class VendaController : Controller
    {
        readonly VendaBLL _vendaBll = new VendaBLL();
        readonly VendaDAL _vendaDal = new VendaDAL();

        public ActionResult Index()
        {
            return View(_vendaDal.GetAll().ToList());
        }

        public ActionResult GerarVenda(int id)
        {

            try
            {
                _vendaBll.Insert(id);
                TempData["Success"] = "Venda Adicionada com sucesso!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.InnerException;
                return RedirectToAction("Index");
            }


        }


        //public ActionResult GerarRelatorio()
        //{
            
        //}
    }
}