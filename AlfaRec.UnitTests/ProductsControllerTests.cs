using AlfaRec.Controllers;
using AlfaRec.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Moq;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AlfaRec.UnitTests
{
    public class ProductControllerTests
    {
        [Theory]
        [InlineData("chleb",2.50)]
        public async Task AddProductTest(string name, decimal price)
        {
            var options = new DbContextOptionsBuilder<ProductContext>()
                  .UseInMemoryDatabase(Guid.NewGuid().ToString())
                  .Options;
            var context = new ProductContext(options);
            ProductsController controller = new ProductsController(context);
            Product product = new Product(name, price);

            await controller.PostProduct(product);
            Assert.Equal(context.Products.Where(x => x.Name == product.Name).FirstOrDefault().Name,product.Name);
            Assert.Equal(context.Products.Where(x => x.Price == product.Price).FirstOrDefault().Price, product.Price);
        }
    }
}
