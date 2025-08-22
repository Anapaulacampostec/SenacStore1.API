using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenacStore1.API.Models
{
    public class Produto
    {
        [Key] //minha chave
        public int Id { get; set; }

        [Required] //campo obrigatório
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }

        [Required]
        [StringLength(200)]
        public string Imagem { get; set; }

        [Required]
        [Range(1, 5)]
        public int Nota { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }

        [Required]
        public bool EhLancamento { get; set; }

        [Required]
        [StringLength(50)]
        public string Categoria { get; set; }


    }
}
