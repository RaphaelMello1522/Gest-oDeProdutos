using GestãoDeProdutos.Models;
using System.Collections.Generic;

namespace GestãoDeProdutos.Services
{
    public interface ProductService
    {
        public List<Product> FindAll();
        public Product Find(int id);
        public void Create(Product product);
        public void Delete(int id);
        public void Update(Product product);

    }
}
