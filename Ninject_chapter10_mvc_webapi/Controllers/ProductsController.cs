using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ninject_chapter10_mvc_webapi.Models;

namespace Ninject_chapter10_mvc_webapi.Controllers
{
    public class ProductsController : ApiController
    {
        IRepository repo;

        public ProductsController(IRepository repoImpl)
        {
            repo = repoImpl;
        }

        public IEnumerable<Product> GetAll()
        {
            return repo.Products;
        }
    }
}
