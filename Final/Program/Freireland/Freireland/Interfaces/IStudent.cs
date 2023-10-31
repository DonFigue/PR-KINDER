using Freireland.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freireland.Interfaces
{
    internal interface IStudent : IBase<Students>
    {
        int Insert(Students t);
        Students Get(short id);
        int UpdateStudent(Person p, Students t);
    }
}
