using MiPrimerAPI.Models;

namespace MiPrimerAPI.Repositories
{
    // Repositories/IProductRepository.cs
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync(); // Trae todos los productos
    Task<Product?> GetByIdAsync(int id); // Trae producto por ID
        Task AddAsync(Product product); // Guarda un producto nuevo
    }

}

