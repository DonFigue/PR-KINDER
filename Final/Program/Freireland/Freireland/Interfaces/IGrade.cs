using Freireland.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Interfaces
{
    public interface IGrade: IBase<Grades>
    {
        int Insert(Grades t);
        Grades Get(short id);
    }
}
