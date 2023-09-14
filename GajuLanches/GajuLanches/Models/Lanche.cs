using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GajuLanches.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado.")]
        [Display(Name = "Nome do lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2} caracteres.")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O descrição do lanche deve ser informado.")]
        [Display(Name = "Descrição do lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição não pode exceder {1} caracteres")]
        public string DescricaoCurta { get; set; }


        [Required(ErrorMessage = "O descrição detalhada do lanche deve ser informado.")]
        [Display(Name = "Descrição detalhada do lanche")]
        [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada não pode exceder {1} caracteres")]
        public string DescricaoDetalhada { get; set; }


        [Required(ErrorMessage = "Informe o preço do lanche.")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }


        [Display(Name = "Caminho da Imagem normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }


        [Display(Name = "Caminho da Imagem miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }


        [Display(Name = "Preferido?")]
        public bool isLanchePreferido { get; set; }


        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }


        //Relacionamento
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}
