using Efinance.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efinance.Repositories.Interfaces
{
   public interface IClienteService
    {

        //select all
        Task<IEnumerable<Cliente>> GetAllAsync();

        //select one
        Task<Cliente> GetAsync(int id);
        //insert
        Task<int> AddAsync(Cliente cli);
        //delete
        Task<bool> Remove(int id);
        //update
        Task<bool> UpdateAsync(Cliente cli);
    }
}
