using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud.Models;
using MVCCrud.Models.View_models;

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
                lst = (from d in db.Personas
                      select new ListTablaviewmodels
                      {
                          Id = d.IdPersona,
                          perCedula = d.perIdentificacion,
                          perNombres = d.perNombres,
                          perApellidos = d.perApellidos,
                          perGenero = d.perGenero,
                          perCorreo = d.perCorreo,
                         

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
            if(ModelState.IsValid)
            {
               using (Clinipet1Entities db= new Clinipet1Entities())
               {
                        var oUsuarios = new Personas();
                        oUsuarios.perNombres = model.perNombres;
                        oUsuarios.perIdentificacion = model.perCedula;
                        oUsuarios.perApellidos = model.perApellidos;
                        oUsuarios.perGenero = model.perGenero;
                        oUsuarios.perCorreo = model.perCorreo;
                       

                        db.Personas.Add(oUsuarios);
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
                var oPersonas = db.Personas.Find(Id);
                model.perCedula = oPersonas.perIdentificacion;
                model.perNombres = oPersonas.perNombres;
                model.perApellidos = oPersonas.perApellidos;
                model.perGenero = oPersonas.perGenero;
                model.perCorreo = oPersonas.perCorreo;

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
                        var oPersonas = db.Personas.Find(model.Id);
                        oPersonas.perNombres = model.perNombres;
                        oPersonas.perIdentificacion = model.perCedula;
                        oPersonas.perApellidos = model.perApellidos;
                        oPersonas.perGenero = model.perGenero;
                        oPersonas.perCorreo = model.perCorreo;


                        db.Entry(oPersonas).State = System.Data.Entity.EntityState.Modified;
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
                var oPersonas = db.Personas.Find(Id);
                db.Personas.Remove(oPersonas);
                db.SaveChanges();
             

            }
            return Redirect("~/Usuarios/");

        }
    }
}