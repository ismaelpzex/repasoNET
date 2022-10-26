using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampThanos.DataAccess.Contracts
{
    public interface IUnitOfWork
    {
        public void Commit();
    }
}
