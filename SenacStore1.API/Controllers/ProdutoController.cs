using Microsoft.AspNetCore.Mvc;
using SenacStore1.API.Data;
using SenacStore1.API.DTO;
using SenacStore1.API.Interface;
using SenacStore1.API.Models;
using static System.Net.Mime.MediaTypeNames;

namespace SenacStore1.API.Controllers
{
    public class ProdutoController : ControllerBase
    {

        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }


        // POST api/<ClienteController>
        [HttpPost("Post")]
        public async Task<ActionResult> Post([FromBody] InputProdutoDTO dto)
        {
            var produto = new Produto
            {
                Nome = dto.Nome,
                Descricao = dto.Descricao,
                Imagem = dto.Imagem,
                Nota = dto.Nota,
                Preco = Convert.ToDecimal(dto.Preco),
                EhLancamento = (bool)dto.EhLancamento,
                Categoria = dto.Categoria,
            };
            await _produtoRepository.AddAsync(produto);
            return Ok();
        }


        //Get /api/produto  
        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAllAsync()
        {
            var produtos = await _produtoRepository.GetAllAsync();
            var resultado = new List<OutPutProdutoDTO>();

            foreach (var produto in produtos)
            {
                resultado.Add(new OutPutProdutoDTO
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    Descricao = produto.Descricao,
                    Imagem = produto.Imagem,
                    Nota = produto.Nota,
                    Preco = Convert.ToDecimal(produto.Preco),
                    EhLancamento = (bool)produto.EhLancamento,
                    Categoria = produto.Categoria,
                });
            }
            return Ok(resultado);

        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] InputProdutoDTO dto)
        {
            var produto = new Produto
            {
                Id = id,
                Nome = dto.Nome,
                Descricao = dto.Descricao,
                Imagem = dto.Imagem,
                Nota = dto.Nota,
                Preco = Convert.ToDecimal(dto.Preco),
                EhLancamento = (bool)dto.EhLancamento,
                Categoria = dto.Categoria,
            };
            await _produtoRepository.UpdateAsync(produto);
            return Ok();
        }

        //delete
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete (int id)
        {
            await _produtoRepository.DeleteAsync(id);
            return Ok();
        }

    }
}
