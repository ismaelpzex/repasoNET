using BootcampThanos.BusinessModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampThanos.Application.Contracts.Servicios
{
    public interface IProductService
    {
        ProductResponse? GetProductByCode(string code);
    }
}
