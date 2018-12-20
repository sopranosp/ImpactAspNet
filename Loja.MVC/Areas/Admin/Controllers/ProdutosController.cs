using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Loja.Dominio;
using Loja.Mvc.Mapeamento;
using Loja.MVC.Areas.Admin.Models;
using Loja.Repositorio.SqlServer;

namespace Loja.MVC.Areas.Admin.Controllers
{
    public class ProdutosController : Controller
    {
        private LojaDbContext db = new LojaDbContext();

        private readonly ProdutoMapeamento Map = new ProdutoMapeamento();


        [AllowAnonymous]
        // GET: Admin/Produtos
        public ActionResult Index()
        {
            // var Produtos = db.Produtos.Include(p => p.ProdutoImagem);


            //throw new Exception("Teste MARIA MARIA");
            return View(Map.Mapear(db.Produtos.ToList()));
        }

        // GET: Admin/Produtos/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(Map.Mapear(produto));
        }

        // GET: Admin/Produtos/Create
        public ActionResult Create()
        {
            //ViewBag.Id = new SelectList(db.ProdutoImagems, "ProdutoId", "ContentType");
            return View(Map.Mapear(new Produto(), db.Categorias.ToList()));
        }

        // POST: Admin/Produtos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var produto = Map.Mapear(viewModel, db);

                db.Produtos.Add(produto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.ProdutoImagems, "ProdutoId", "ContentType", viewModel.Id);
            return View(viewModel);
        }

        // GET: Admin/Produtos/Edit/5
        public ActionResult Edit(int? id)
        {

            if (((ClaimsIdentity)User.Identity)
                    .HasClaim(c => c.Type == "Produtos" && c.Value.Contains("|Edit|")))

            {
                RedirectToAction("Login", "Account");

            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.ProdutoImagems, "ProdutoId", "ContentType", produto.Id);
            return View(Map.Mapear(produto,db.Categorias.ToList()));
        }

        // POST: Admin/Produtos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Preco,Estoque,Ativo")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.ProdutoImagems, "ProdutoId", "ContentType", produto.Id);
            return View(produto);
        }
        [Authorize(Roles = "Master")]
        [Authorize(Roles = "Gerente, Admin")]
        // GET: Admin/Produtos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(Map.Mapear(produto));
        }

        // POST: Admin/Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produto produto = db.Produtos.Find(id);
            db.Produtos.Remove(produto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [ActionName("Categoria")]
        public ActionResult ObterProdutoPorCategoria(int categoriaid)
        {
            var produtos = db.Produtos.Where(p => p.Categoria.Id == categoriaid)
                .Select(P => new { P.Nome, P.Preco, P.Estoque })
                .ToList();
            return Json(produtos, JsonRequestBehavior.AllowGet);

        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
