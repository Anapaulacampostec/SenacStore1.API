using SenacStore1.API.Models;

namespace SenacStore1.API.Interface
{
    public interface IProdutoRepository
    {
       
            Task<List<Produto>> GetAllAsync();
            Task<Produto?> GetBydIdAsync(int id);
            Task AddAsync(Produto produto);
            Task UpdateAsync(Produto produto);
            Task DeleteAsync(int id);
       
    }
}
