using APICompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICompras.Services
{
    public interface ICompraService
    {
        IEnumerable<CompraItem> GetAllItems();
        CompraItem Add(CompraItem novoItem);
        CompraItem GetById(int id);
        void Remove(int id);
    }
}
