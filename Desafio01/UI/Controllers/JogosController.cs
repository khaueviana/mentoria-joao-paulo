using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class JogosController : Controller
    {

        
        List<JogosModel> lista = new List<JogosModel>();

        // GET: Jogos
        public ActionResult Index() {

            
            return View(lista.ToList());
        }//Index

        // GET: Jogos/Details/5
        public ActionResult Details(int id)  {
            return View();
        }//Details

        // GET: Jogos/Create
        public ActionResult Create() {

            return View();
        }

        // POST: Jogos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JogosModel jogos) {
            try {
                // TODO: Add insert logic here
                
                lista.Add(jogos);

                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }//Create

        // GET: Jogos/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: Jogos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }//Edit

        // GET: Jogos/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: Jogos/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try{
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch{
                return View();
            }
        }//Delete


    }
}