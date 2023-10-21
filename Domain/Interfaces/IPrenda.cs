using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces;
    public interface IPrenda : IGeneric<Prenda>
    {
        Task<IEnumerable<Prenda>> GetInsumosxPrenda(int codigo);
    }
