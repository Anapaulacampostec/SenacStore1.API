using Microsoft.EntityFrameworkCore;
using SenacStore1.API.Data;
using SenacStore1.API.Interface;
using SenacStore1.API.Models;

namespace SenacStore1.API.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly SenacStore1DbContext _context;

        public ProdutoRepository(SenacStore1DbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Produto produto)
        {
            //insere (salva) o registro na tabela
            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            //apaga o registro da tabela
            var produto = await _context.Produtos.FindAsync(id);
            if (produto!= null)
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Produto>> GetAllAsync()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto?> GetBydIdAsync(int id)
        {
           return await _context.Produtos.FirstOrDefaultAsync(x => x.Id == id);
        }


        public async Task UpdateAsync(Produto produto)
        {
            _context.Update(produto);
            await _context.SaveChangesAsync();
        }
    }
}
