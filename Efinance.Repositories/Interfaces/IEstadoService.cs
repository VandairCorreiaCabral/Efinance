using Efinance.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efinance.Repositories.Interfaces
{
    public interface IEstadoService
    {
      
        //select all
        Task<IEnumerable<Uf>> GetAllAsync();
      
        //select one
        Task<Uf> GetAsync(int id);
        //insert
        Task<int> AddAsync(Uf uf);
        //delete
        Task<bool> Remove(int id);
        //update
        Task<bool> UpdateAsync(Uf uf);
    }
}
