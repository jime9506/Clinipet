using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud.Models;
using MVCCrud.Models.View_models;


namespace MVCCrud.Controllers
{
    public class MascotasController : Controller
    {

        // GET: Mascotas
        public ActionResult Index()
        {
            List<Mascotasviewmodels> lst;
            using (Clinipet1Entities db = new Clinipet1Entities())
            {
                lst = (from d in db.Mascota
                       select new Mascotasviewmodels
                       {
                           IdMascota = d.IdMascota,
                           Categoria = d.Categoria,
                           NombreMascota= d.NombreMascota,
                           Telefono = d.Telefono,
                           Raza= d.Raza,
                           Edad= d.Edad,
                           Sexo = d.Sexo,
                           Acudiente = d.Acudiente,
                       }).ToList();

            }
            return View(lst);
        }
        public ActionResult Crear()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Crear(Mascotasviewmodels model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Clinipet1Entities db = new Clinipet1Entities())
                    {
                        var Mascota = new Mascota();
                        Mascota.Categoria= model.Categoria;
                        Mascota.NombreMascota = model.NombreMascota;
                        Mascota.Telefono = model.Telefono;
                        Mascota.Raza = model.Raza;
                        Mascota.Edad= model.Edad;
                        Mascota.Sexo = model.Sexo;
                        Mascota.Acudiente = model.Acudiente;

                        db.Mascota.Add(Mascota);
                        db.SaveChanges();
                    }

                    return Redirect("~/Mascotas");
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

            Mascotasviewmodels model = new Mascotasviewmodels();
            using (Clinipet1Entities db = new Clinipet1Entities())
            {
                var Mascotas = db.Mascota.Find(Id);
                model.IdMascota = Mascotas.IdMascota;
                model.Categoria = Mascotas.Categoria;
                model.NombreMascota = Mascotas.NombreMascota;
                model.Telefono = Mascotas.Telefono;
                model.Raza = Mascotas.Raza;
                model.Edad = Mascotas.Edad;
                model.Sexo= Mascotas.Sexo;
            }
            return View(model);

        }
        [HttpPost]
        public ActionResult Editar(Mascotasviewmodels model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Clinipet1Entities db = new Clinipet1Entities())
                    {
                        var Mascotas = db.Mascota.Find(model.IdMascota);
                        
                        Mascotas.Categoria = model.Categoria;
                        Mascotas.NombreMascota = model.NombreMascota;
                        Mascotas.Telefono = model.Telefono;
                        Mascotas.Raza = model.Raza;
                        Mascotas.Edad = model.Edad;
                        Mascotas.Sexo = model.Sexo;

                        db.Entry(Mascotas).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/Mascotas");
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
                var Mascotas = db.Mascota.Find(Id);
                db.Mascota.Remove(Mascotas);
                db.SaveChanges();


            }
            return Redirect("~/Mascotas/");

        }
    }
}
    

    