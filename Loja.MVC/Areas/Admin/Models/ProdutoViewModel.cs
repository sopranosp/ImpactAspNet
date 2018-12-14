﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Loja.MVC.Areas.Admin.Models
{
    public class ProdutoViewModel
    {

        
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public String CategoriaNome { get; set; }


        [Required]
        [Display(Name ="Categoria")]
         public int? CategoriaId { get; set; }

        public List<SelectListItem> Categorias { get; set; }

        [Required]
        [Display(Name = "Preço R$")]
        public decimal Preco { get; set; }

        [Required]
        public int Estoque { get; set; }

        public bool Ativo { get; set; }

    }
}