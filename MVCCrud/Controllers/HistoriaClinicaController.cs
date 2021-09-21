using System;
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
            List<HistoriaClinicaviewmodels> lst;
            using (Clinipet1Entities db = new Clinipet1Entities())
            {
                lst = (from d in db.HistoriaClinica
                       select new HistoriaClinicaviewmodels
                       {                          
                           Emfermedades = d.Emfermedades,
                           Vacunas = d.Vacunas,
                           Peso = d.Peso,

                       }).ToList();
            }
            return View(lst);
        }


        // GET: HistoriaClinica/Details/5

        public ActionResult Crear()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Crear(HistoriaClinicaviewmodels model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Clinipet1Entities db = new Clinipet1Entities())
                    {
                        var HistoriaClinica = new HistoriaClinica();
                        HistoriaClinica.IdMascota = model.IdMascota;
                        HistoriaClinica.Emfermedades = model.Emfermedades;
                        HistoriaClinica.Vacunas = model.Vacunas;
                        HistoriaClinica.Peso = model.Peso;

                        db.HistoriaClinica.Add(HistoriaClinica);
                        db.SaveChanges();
                    }

                    return Redirect("~/HistoriaClinica");
                }

                return View(model);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
            public ActionResult Editar(int Id)
            {

                HistoriaClinicaviewmodels model = new HistoriaClinicaviewmodels();
                using (Clinipet1Entities db = new Clinipet1Entities())
                {
                    var HistoriaClinica = db.HistoriaClinica.Find(Id);
                    model.Emfermedades = HistoriaClinica.Emfermedades;
                    model.Vacunas= HistoriaClinica.Vacunas;
                    model.Peso = HistoriaClinica.Peso;
                }
                return View(model);

            }
        [HttpPost]
        public ActionResult Editar(HistoriaClinicaviewmodels model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Clinipet1Entities db = new Clinipet1Entities())
                    {
                        var HistoriaClinica = db.HistoriaClinica.Find(model.IdMascota);
                        HistoriaClinica.Emfermedades = model.Emfermedades;
                        HistoriaClinica.Vacunas = model.Vacunas;
                        HistoriaClinica.Peso= model.Peso;
                        db.Entry(HistoriaClinica).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/HistoriaClinica");
                }

                return View(model);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        [HttpGet]
        public ActionResult Eliminar(int Id)
        {

            using (Clinipet1Entities db = new Clinipet1Entities())
            {
                var HistoriaClinica = db.HistoriaClinica.Find(Id);
                db.HistoriaClinica.Remove(HistoriaClinica);
                db.SaveChanges();


            }
            return Redirect("~/HistoriaClinica/");

        }



    }
}
