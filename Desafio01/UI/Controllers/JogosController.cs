using BLL;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UI.Models;

namespace UI.Controllers
{
    public class JogosController : Controller {

      
        

        // GET: Jogos
        public ActionResult Index() {


           
            return View();
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

                JogosDTO dto = new JogosDTO();
                JogosBLL bll = new JogosBLL();

                dto.Id = jogos.Id;
                dto.Nome = jogos.Nome;
                dto.Descricao = jogos.Descricao;
                dto.CodigoBarra = jogos.CodigoBarra;
                dto.Preco = jogos.Preco;
                dto.QuantidadeEstoque = jogos.QuantidadeEstoque;
                bll.Cadastrar(dto);

                
                return (RedirectToAction("Index", new {jogos}));
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