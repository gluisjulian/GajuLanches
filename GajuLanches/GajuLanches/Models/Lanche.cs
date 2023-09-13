﻿namespace GajuLanches.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; } 
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool isLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }


        //Relacionamento
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}
