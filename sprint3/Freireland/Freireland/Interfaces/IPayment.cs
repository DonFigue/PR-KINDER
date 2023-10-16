using Freireland.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Interfaces
{
    internal interface IPayment : IBase<Payment>
    {
        Payment GET(int id);
    }
}
