using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Freireland.Model;

namespace Freireland.Interfaces
{
    public interface IAttorney : IBase<Attorney>
    {
        Attorney GET(int id);
    }
}
