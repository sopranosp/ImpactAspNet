﻿namespace Loja.Dominio
{
    public class ProdutoImagem
    {

        public int ProdutoId { get; set; }

        public byte[] Bytes { get; set; }

        public string ContentType { get; set; }

        public Produto Produto { get; set; }


    }
}