﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using ViagensOnline.Mvc.Models;
using ViagensOnline.Repositorios.SqlServer;
using ViagensOnlineMvc.Models;

namespace ViagensOnline.Mvc.Controllers
{
    public class LoginController : Controller
    {
        private readonly ViagensOnlineDbContext db = new ViagensOnlineDbContext();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var usuario = db.Usuarios.SingleOrDefault(u =>
                u.Email == viewModel.Email &&
                u.Senha.Equals(viewModel.Senha));

            if (usuario == null)
            {
                ModelState.AddModelError("", "Usuário ou senha inválidos.");

                //ModelState.Clear();

                return View(new LoginViewModel());
            }



            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, viewModel.Email));
            claims.Add(new Claim(ClaimTypes.Name , viewModel.Email));
            claims.Add(new Claim(ClaimTypes.Role, "Gerente"));
            claims.Add(new Claim(ClaimTypes.Role, "Admin"));
            claims.Add(new Claim("Sua Claim", "Admin"));
            claims.Add(new Claim("Destinos", "|Edit|Create|Delete|"));

            var identidade = new ClaimsIdentity(claims, Cookie.ViagensOnlineCookieAuthentication.ToString());
            Request.GetOwinContext().Authentication.SignIn(identidade);
            return RedirectToAction("Index", "Home");
            
           // return View();
        }


        [HttpPost]
        public ActionResult LogOff()
        {
            Request.GetOwinContext()
                .Authentication.SignOut(Cookie.ViagensOnlineCookieAuthentication.ToString());

            return RedirectToAction("Index", "Home");
        }


        
    }
}