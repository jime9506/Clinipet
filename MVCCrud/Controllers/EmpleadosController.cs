using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud.Models;
using MVCCrud.Models.View_models;

namespace MVCCrud.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult Index()
        {
            List<Empleadosviewmodels> lst;
            using (Clinipet1Entities db = new Clinipet1Entities())
            {
                lst = (from d in db.Empleados
                       select new Empleadosviewmodels
                       {
                           Id = d.Id,
                           Cargo = d.Cargo,
                           FechaContratacion = d.FechaContratacion,
                           TipoContratacion = d.TipoContrato,                         

                       }).ToList();
            }
            return View(lst);
        }

        public ActionResult Crear()
        {
            return View();

        }
        [HttpPost]
        // GET: Empleados/Details/5
        public ActionResult Crear (Empleadosviewmodels model )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Clinipet1Entities db = new Clinipet1Entities())
                    {
                        var oEmpleados = new Empleados();
                        oEmpleados.Id = model.Id;
                        oEmpleados.Cargo = model.Cargo;
                        oEmpleados.FechaContratacion = model.FechaContratacion;
                        oEmpleados.TipoContrato = model.TipoContratacion;                                                ;

                        db.Empleados.Add(oEmpleados);
                        db.SaveChanges();
                    }

                    return Redirect("~/Empleados");
                }

                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // GET: Empleados/Create
        public ActionResult Editar (int Id)
        { 

            Empleadosviewmodels model = new Empleadosviewmodels();
            using (Clinipet1Entities db = new Clinipet1Entities())
            {
                var Empleados = db.Empleados.Find(Id);
                model.Id = Empleados.Id;
                model.Cargo = Empleados.Cargo;
                model.FechaContratacion = Empleados.FechaContratacion;
                model.TipoContratacion = Empleados.TipoContrato;             
            }
            return View(model);

        }
        // GET: Empleados/Edit/5
        [HttpPost]
        public ActionResult Editar (Empleadosviewmodels model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Clinipet1Entities db = new Clinipet1Entities())
                    {
                        var Empleados = db.Empleados.Find(model.Id);
                        Empleados.Id = model.Id;
                        Empleados.Cargo = model.Cargo;
                        Empleados.FechaContratacion= model.FechaContratacion;
                        Empleados.TipoContrato = model.TipoContratacion;

                        db.Entry(Empleados).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/Empleados");
                }
                    return View (model);
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
                var Empleados = db.Empleados.Find(Id);
                db.Empleados.Remove(Empleados);
                db.SaveChanges();


            }
            return Redirect("~/Empleados/");

        }
    }
}

