﻿using System;
using KurumsalWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using KurumsalWeb.Models.DataContext;
using KurumsalWeb.Models.Model;

namespace KurumsalWeb.Controllers
{
    public class AdminController : Controller
    {
       KurumsalDBContext db = new KurumsalDBContext();
        // GET: Admin
        
        public ActionResult Index()
        {
            var sorgu = db.Kategori.ToList();
            return View(sorgu);
        }
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {

            var login = db.Admin.Where(x => x.Eposta == admin.Eposta).SingleOrDefault();
            if (login.Eposta == admin.Eposta && login.Sifre == admin.Sifre)
            {
                Session["adminid"] = login.AdminId;
                Session["eposta"] = login.Eposta;
                Session["yetki"] = login.Yetki;
                return RedirectToAction("Index", "Admin");
            }
            ViewBag.Uyari = "Kullanıcı adı yada şifre yanlış";
            return View(admin);

        }

        public ActionResult Logout()
        {
            Session["adminid"] = null;
            Session["eposta"] = null;
            Session.Abandon();
            return RedirectToAction("Login", "Admin");
        } 
    }
}