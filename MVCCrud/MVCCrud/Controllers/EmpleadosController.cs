using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCrud.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
            List<ListTablaviewmodels> lst;
            using (Clinipet1Entities db = new Clinipet1Entities())
            {
                lst = (from d in db.Empleados
                       select new ListTablaviewmodels
                       {
                           Id = d.Id,
                           Cargo = d.Cargo,
                           FechaContratacion = d.FechaContratacion,
                           TipoContrato= d.TipoContrato,


                       }).ToList();

            }
            return View(lst);
        }
        public ActionResult Nuevo()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Nuevo(Usuariosviewmodels model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Clinipet1Entities db = new Clinipet1Entities())
                    {
                        var oUsuarios = new Empleados();
                        oEmpleados.Cargo = model.Cargo;
                        oEmpleados.FechaContratacion = model.FechaContratacion;
                        oEmpleados.TipoContrato = model.TipoContrato;
                        


                        db.Empleados.Add(oUsuarios);
                        db.SaveChanges();
                    }

                    return Redirect("~/Usuarios/");
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

            Usuariosviewmodels model = new Usuariosviewmodels();
            using (Clinipet1Entities db = new Clinipet1Entities())
            {
                var oPersonas = db.Empleados.Find(Id);
                model.Cargo= oEmpleados.Cargo;
                model.FechaContratacion = oEmpleados.FechaContratacion;
                model.TipoContrato = oEmpleados.TipoContrato;

            }
            return View(model);

        }
        [HttpPost]
        public ActionResult Editar(Usuariosviewmodels model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Clinipet1Entities db = new Clinipet1Entities())
                    {
                        var oEmpleados = db.Empleados.Find(model.Id);
                        model.Cargo = oEmpleados.Cargo;
                        model.FechaContratacion = oEmpleados.FechaContratacion;
                        model.TipoContrato = oEmpleados.TipoContrato;


                        db.Entry(oEmpleados).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/Usuarios");
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
                var oEmpleados = db.Empleados.Find(Id);
                db.Empleados.Remove(oEmpleados);
                db.SaveChanges();


            }
            return Redirect("~/Usuarios/");

        }
    }
}
}
