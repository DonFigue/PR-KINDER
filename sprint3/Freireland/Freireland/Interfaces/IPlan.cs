using Freireland.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Interfaces
{
    internal interface IPlan : IBase<Plan>
    {
        Plan GET(int id);
    }
}
