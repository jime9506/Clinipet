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
            List<Usuarioviewmodels> lst;
            using (Clinipet1Entities db = new Clinipet1Entities())
            {
                lst = (from d in db.Usuario
                       select new Usuarioviewmodels
                       {
                           Id = d.IdUsuario,
                           Email = d.Email,
                           Password = d.Password,
                           IdRol = d.IdRol,

                       }).ToList();

            }
            return View(lst);
        }
        public ActionResult Crear()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Crear(Usuarioviewmodels model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Clinipet1Entities db = new Clinipet1Entities())
                    {
                        var Usuario = new Usuario();
                        Usuario.Email = model.Email;
                        Usuario.Password = model.Password;
                        Usuario.IdRol = model.IdRol;
                        Usuario.IdPersona = model.IdPersona;

                        db.Usuario.Add(Usuario);
                        db.SaveChanges();
                    }

                    return Redirect("~/Usuario");
                }

                return View(model);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public ActionResult Editar(long Id)
        {

            Usuarioviewmodels model = new Usuarioviewmodels();
            using (Clinipet1Entities db = new Clinipet1Entities())
            {
                var mUsuario = db.Usuario.Find(Id);
                model.Email = mUsuario.Email;
                model.Password = mUsuario.Password;
                model.IdRol = mUsuario.IdRol;
                model.IdPersona = mUsuario.IdPersona;

            }
            return View(model);

        }
        [HttpPost]
        public ActionResult Editar(Usuarioviewmodels model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Clinipet1Entities db = new Clinipet1Entities())
                    {
                        var Usuario = db.Usuario.Find(model.Id);
                        Usuario.Email = model.Email;
                        Usuario.Password = model.Password;
                        Usuario.IdRol = model.IdRol;
                        Usuario.IdPersona = model.IdPersona;     

                        db.Entry(Usuario).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/Usuario");
                }

                return View(model);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        [HttpGet]
        public ActionResult Eliminar(int IdUsuario)
        {

            using (Clinipet1Entities db = new Clinipet1Entities())
            {
                var Usuario = db.Usuario.Find(IdUsuario);
                db.Usuario.Remove(Usuario);
                db.SaveChanges();


            }
            return Redirect("~/Usuario/");

        }
    }
}
