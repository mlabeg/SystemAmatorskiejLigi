﻿using LigaAmatorska.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Domain.Interfaces
{
    public interface IStatystykiRepository
    {
        public Task<int> DodajStatystyki(Statystyki statystyki);
    }
}