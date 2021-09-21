using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud.Models;
using MVCCrud.Models.View_models;

namespace MVCCrud.Controllers
{
        public class EmpresaController : Controller
        {
            // GET: Tabla
            public ActionResult Index()
            {
                List<Empresaviewmodels> lst;
                using (Clinipet1Entities db = new Clinipet1Entities())
                {
                    lst = (from d in db.Empresa
                           select new Empresaviewmodels
                           {
                               Id = d.IdEmpresa,
                               perNombre = d.perNombre,
                               perCorreo = d.perCorreo,
                               perNit = d.perNit,


                           }).ToList();

                }
                return View(lst);
            }

            public ActionResult Crear()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Crear(Empresaviewmodels model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Clinipet1Entities db = new Clinipet1Entities())
                    {
                        var Empresa = new Empresa();
                        Empresa.perNombre= model.perNombre;
                        Empresa.perCorreo = model.perCorreo;
                        Empresa.perNit = model.perNit;

                        db.Empresa.Add(Empresa);
                        db.SaveChanges();
                    }

                    return Redirect("~/Empresa");
                }

                return View(model);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        // GET: Empresa/Details/5
        
        public ActionResult Editar(int Id)
        {

            Empresaviewmodels model = new Empresaviewmodels();
            using (Clinipet1Entities db = new Clinipet1Entities())
            {
                var Empresa = db.Empresa.Find(Id);
                model.perNombre= Empresa.perNombre;
                model.perCorreo = Empresa.perCorreo;
                model.perNit = Empresa.perNit;
            }
            return View(model);

        }
        // GET: Empresa/Create
        [HttpPost]
        public ActionResult Editar(Empresaviewmodels model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Clinipet1Entities db = new Clinipet1Entities())
                    {
                        var mEmpresa = db.Empresa.Find(model.Id);
                        mEmpresa.perNombre= model.perNombre;
                        mEmpresa.perCorreo= model.perCorreo;
                        mEmpresa.perNit= model.perNit;
                        

                        db.Entry(mEmpresa).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/Empresa");
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
                var Empresa = db.Empresa.Find(Id);
                db.Empresa.Remove(Empresa);
                db.SaveChanges();


            }
            return Redirect("~/Empresa/");

        }
    }
}
