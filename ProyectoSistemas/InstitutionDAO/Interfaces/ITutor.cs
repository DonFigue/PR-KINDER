﻿using InstitutionDAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutionDAO.Interfaces
{
    internal interface ITutor
    {
        void InsertTutor(Person p, Tutor t);
        void UpdateTutor(Person p, Tutor t);
    }
}