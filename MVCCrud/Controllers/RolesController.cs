using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud.Models;
using MVCCrud.Models.View_models;


public class RolesController : Controller
{
    // GET: Tabla
    public ActionResult Index()
    {
        List<Rolesviewmodels> lst;
        using (Clinipet1Entities db = new Clinipet1Entities())
        {
            lst = (from d in db.Roles
                   select new Rolesviewmodels
                   {
                       IdRol = d.IdRol,
                       Rol = d.Rol,

                   }).ToList();

        }
        return View(lst);
    }
    public ActionResult Crear()
    {
        return View();

    }
    [HttpPost]
    public ActionResult Crear(Rolesviewmodels model)
    {
        try
        {
            if (ModelState.IsValid)
            {
                using (Clinipet1Entities db = new Clinipet1Entities())
                {
                    var Roles = new Roles();
                    Roles.IdRol = model.IdRol;
                    Roles.Rol = model.Rol;

                    db.Roles.Add(Roles);
                    db.SaveChanges();
                }

                return Redirect("~/Roles");
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

        Rolesviewmodels model = new Rolesviewmodels();
        using (Clinipet1Entities db = new Clinipet1Entities())
        {
            var Roles = db.Roles.Find(Id);
            model.IdRol = Roles.IdRol;
            model.Rol = Roles.Rol;
           
        }
        return View(model);

    }
    [HttpPost]
    public ActionResult Editar(Rolesviewmodels model)
    {
        try
        {
            if (ModelState.IsValid)
            {
                using (Clinipet1Entities db = new Clinipet1Entities())
                {
                    var Roles = db.Roles.Find(model.IdRol);
                    Roles.IdRol = model.IdRol;
                    Roles.Rol = model.Rol;               

                    db.Entry(Roles).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }

                return Redirect("~/Roles");
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
            var Roles = db.Roles.Find(Id);
            db.Roles.Remove(Roles);
            db.SaveChanges();


        }
        return Redirect("~/Roles/");

    }
}
