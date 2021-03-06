﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TS.BLL;
using TS.DAL;
using TS.DTO.Classes;


namespace TS.UI.Controllers
{
    public class UsuarioController : Controller
    {

        readonly UsuarioBLL _usuarioBll = new UsuarioBLL();
        readonly UsuarioDAL _usuarioDal = new UsuarioDAL();
        readonly TipoUsuarioDAL _tipoUsuarioDal = new TipoUsuarioDAL();

        // GET: Usuario
        public ActionResult Index()
        {
            return View(_usuarioDal.GetAll().ToList());
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            ViewBag.TipoId = new SelectList(_tipoUsuarioDal.GetAll(), "Id", "Descricao");

            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario usuario, int tipoId)
        {
            try
            {
                _usuarioBll.Insert(usuario, tipoId);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.InnerException.Message;

                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuario/Edit/5
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

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
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