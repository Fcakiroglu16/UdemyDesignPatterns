using BaseProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Strategy.Models;

namespace WebApp.Strategy.Repositories
{
    public class ProductRepositoryFromSqlServer : IProductRepository
    {
        private readonly AppIdentityDbContext _context;
        public ProductRepositoryFromSqlServer(AppIdentityDbContext appIdentityDbContext)
        {
            _context = appIdentityDbContext;
        }

        public async Task Delete(Product product)
        {

           // _context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.Products.Remove(product);

            await _context.SaveChangesAsync();

        }

        public async Task<List<Product>> GetAllByUserId(string userId)
        {
            return await _context.Products.Where(x => x.UserId == userId).ToListAsync();
        }

        public async Task<Product> GetById(string id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> Save(Product product)
        {

            product.Id = Guid.NewGuid().ToString();
            await _context.Products.AddAsync(product);

            await _context.SaveChangesAsync();

            return product;
        }

        public async Task Update(Product product)
        {
            _context.Products.Update(product);

            await _context.SaveChangesAsync();
        }
    }
}
