namespace GajuLanches.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        //Relacionamento
        public List<Lanche> Lanches { get; set; }
    }
}
