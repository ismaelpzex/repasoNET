using BootcampThanos.Application.Contracts.Servicios;
using BootcampThanos.BusinessModels.Models;
using BootcampThanos.DataAccess.Contracts.Models;
using BootcampThanos.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampThanos.Application.Servicios
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductResponse? GetProductByCode(string code)
        {
            ProductDto? product = _productRepository.GetProductByCode(code);

            if (product != null)
            {
                ProductResponse response = new ProductResponse
                {
                    BuyPrice = product.BuyPrice,
                    ProductCode = product.ProductCode,
                    Msrp = product.Msrp,
                    ProductDescription = product.ProductLine,
                    ProductLine = product.ProductLine,
                    ProductName = product.ProductName,
                    ProductScale = product.ProductScale,
                    ProductVendor = product.ProductVendor,
                    QuantityInStock = product.QuantityInStock

                };

                return response;
            }
            else return null;
        }
    }
}
