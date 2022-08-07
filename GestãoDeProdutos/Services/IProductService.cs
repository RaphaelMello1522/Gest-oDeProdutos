using GestãoDeProdutos.Data;
using GestãoDeProdutos.Models;
using System.Collections.Generic;
using System.Linq;

namespace GestãoDeProdutos.Services
{
    public class IProductService : ProductService
    {

        private ApplicationDbContext db;

        public IProductService(ApplicationDbContext _db)
        {
            db = _db;
        }

        public void Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Products.Remove(db.Products.Find(id));
            db.SaveChanges();
        }

        public Product Find(int id)
        {
            return db.Products.Find(id);
        }

        public List<Product> FindAll()
        {
            return db.Products.ToList();
        }

        public void Update(Product product)
        {
            db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
