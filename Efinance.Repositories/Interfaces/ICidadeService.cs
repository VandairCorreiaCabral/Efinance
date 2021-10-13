using Efinance.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efinance.Repositories.Interfaces
{
   public interface ICidadeService
    {
        //select all
        Task<IEnumerable<Cidade>> GetAllAsync();

        //select one
        Task<Cidade> GetAsync(int id);
        //insert
        Task<int> AddAsync(Cidade cid);
        //delete
        Task<bool> Remove(int id);
        //update
        Task<bool> UpdateAsync(Cidade cid);
    }
}
