using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud.Models;
using MVCCrud.Models.View_models;

namespace MVCCrud.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
            List<Personasviewmodels> lst;
            using (Clinipet1Entities db = new Clinipet1Entities())
            {
                lst = (from d in db.Personas
                       select new Personasviewmodels
                       {
                           Id = d.IdPersona,
                           perIdentificacion = d.perIdentificacion,
                           perNombres = d.perNombres,
                           perApellidos = d.perApellidos,
                           perGenero = d.perGenero,
                           perCorreo = d.perCorreo,
                           perFechaNacimiento = d.perFechaNacimiento,


                       }).ToList();

            }
            return View(lst);
        }
        public ActionResult Crear()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Crear(Personasviewmodels model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Clinipet1Entities db = new Clinipet1Entities())
                    {
                        var oUsuarios = new Personas();
                        oUsuarios.perNombres = model.perNombres;
                        oUsuarios.perIdentificacion = model.perIdentificacion;
                        oUsuarios.perApellidos = model.perApellidos;
                        oUsuarios.perGenero = model.perGenero;
                        oUsuarios.perCorreo = model.perCorreo;
                        oUsuarios.perFechaNacimiento = model.perFechaNacimiento;
                        
                        db.Personas.Add(oUsuarios);
                        db.SaveChanges();
                    }

                    return Redirect("~/Personas");
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

            Personasviewmodels model = new Personasviewmodels();
            using (Clinipet1Entities db = new Clinipet1Entities())
            {
                var oPersonas = db.Personas.Find(Id);
                model.perIdentificacion = oPersonas.perIdentificacion;
                model.perNombres = oPersonas.perNombres;
                model.perApellidos = oPersonas.perApellidos;
                model.perGenero = oPersonas.perGenero;
                model.perCorreo = oPersonas.perCorreo;
                model.perFechaNacimiento = oPersonas.perFechaNacimiento;
            }
            return View(model);

        }
        [HttpPost]
        public ActionResult Editar(Personasviewmodels model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Clinipet1Entities db = new Clinipet1Entities())
                    {
                        var oPersonas = db.Personas.Find(model.Id);
                        oPersonas.perNombres = model.perNombres;
                        oPersonas.perIdentificacion = model.perIdentificacion;
                        oPersonas.perApellidos = model.perApellidos;
                        oPersonas.perGenero = model.perGenero;
                        oPersonas.perCorreo = model.perCorreo;
                        oPersonas.perFechaNacimiento =  model.perFechaNacimiento;

                        db.Entry(oPersonas).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/Personas");
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
                var oPersonas = db.Personas.Find(Id);
                db.Personas.Remove(oPersonas);
                db.SaveChanges();


            }
            return Redirect("~/Personas/");

        }
    }
}