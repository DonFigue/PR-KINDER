using Freireland.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Interfaces
{
    internal interface ITeacher : IBase<Teachers>
    {
        int Insert(Teachers t);
        Teachers Get(short id);
        int UpdateStudent(Person p, Teachers t);
    }
}
