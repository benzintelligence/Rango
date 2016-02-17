using Rango.Domain.Contracts.Repositories.Base;
using Rango.Domain.Entities.Ordered;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rango.Domain.Contracts.Repositories.Ordered
{
    public interface IPayment : IGenericRepository<Payment>
    {
    }
}
