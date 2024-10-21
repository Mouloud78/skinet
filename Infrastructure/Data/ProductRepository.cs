using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ProductRepository(StoreContext context) : IProductRepository
{
    public void AddProduct(Product product)
    {
        context.Productes.Add(product);
    }

    public void DeleteProduct(Product product)
    {
        context.Productes.Remove(product);
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        return await context.Productes.FindAsync(id);
    }

    public async Task<IReadOnlyList<Product>> GetProductsAsync()
    {
        return await context.Productes.ToListAsync();
    }

    public bool ProducExists(int id)
    {
        return context.Productes.Any(x => x.Id == id);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }

    public void UpdateProduct(Product product)
    {
        context.Entry(product).State = EntityState.Modified;
    }
}
