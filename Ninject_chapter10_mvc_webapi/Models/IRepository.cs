using System.Collections.Generic;


namespace Ninject_chapter10_mvc_webapi.Models
{
    public interface IRepository
    {

        IEnumerable<Product> Products { get; }
        Product GetProduct(int id);
        Product SaveProduct(Product newProduct);
        Product DeleteProduct(int id);
    }
}
