using Freireland.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Interfaces
{
    internal interface ITutor : IBase<Tutor>
    {
        Tutor GET(int id);
    }
}
