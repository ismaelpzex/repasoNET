using BootcampThanos.DataAccess.Contracts.Models;
using BootcampThanos.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampThanos.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ProductDto? GetProductByCode(string productCode)
        {
            var query = from p in _context.Products
                        where p.ProductCode == productCode
                        select new ProductDto
                        {
                            BuyPrice = p.BuyPrice,
                            Msrp = p.Msrp,
                            ProductCode = p.ProductCode,
                            ProductDescription = p.ProductDescription,
                            ProductName = p.ProductName,
                            ProductLine = p.ProductLine,
                            ProductScale = p.ProductScale,
                            ProductVendor = p.ProductVendor,
                            QuantityInStock = p.QuantityInStock,
                        };

            return query.FirstOrDefault();
        }
    }
}
