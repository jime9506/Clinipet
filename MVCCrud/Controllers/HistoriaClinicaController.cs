﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud.Models;
using MVCCrud.Models.View_models;


namespace MVCCrud.Controllers
{
    public class HistoriaClinicaController : Controller
    {
        // GET: HistoriaClinica
        public ActionResult Index()
        {
            return View();
        }

        // GET: HistoriaClinica/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HistoriaClinica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HistoriaClinica/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HistoriaClinica/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HistoriaClinica/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HistoriaClinica/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HistoriaClinica/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}