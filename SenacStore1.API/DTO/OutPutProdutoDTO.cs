using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SenacStore1.API.DTO
{
    public class OutPutProdutoDTO
    {
       
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Imagem { get; set; }

        public int Nota { get; set; }

        public decimal Preco { get; set; }

        public bool EhLancamento { get; set; }


        public string Categoria { get; set; }


    }


}

