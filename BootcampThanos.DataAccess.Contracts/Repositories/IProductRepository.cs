using BootcampThanos.DataAccess.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampThanos.DataAccess.Contracts.Repositories
{
    public interface IProductRepository
    {
        ProductDto? GetProductByCode(string productCode);
    }
}
