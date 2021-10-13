using Efinance.Models.DataBase;
using Efinance.Repositories.Interfaces;
using Efinance.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Efinance.Repositories.Services
{
    public class ClienteService : IClienteService
    {
        private readonly DbConexao _DbConn;
        public ClienteService(DbConexao DbConn)
        {
            _DbConn = DbConn;
        }

        public async Task<int> AddAsync(Cliente clie)
        {
            using (var conn = _DbConn.Connection)
            {

               var ret = await conn.InsertAsync<Cliente>(clie).ConfigureAwait(false);

                return ret;
            }
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            using (var conn = _DbConn.Connection)
            {

                IEnumerable<Cliente> _Cliente = await conn.GetAllAsync<Cliente>().ConfigureAwait(false);

                return _Cliente;
            }
        }

        public async Task<Cliente> GetAsync(int id)
        {
            using (var conn = _DbConn.Connection)
            {

                Cliente clie = await conn.GetAsync<Cliente>(id);
                return clie;

            }
        }

        public async Task<bool> Remove(int id)
        {
            using (var conn = _DbConn.Connection)
            {

                var ret = await conn.DeleteAsync(new Cliente() { ClienteId = id });
                return ret;

            }
        }

        public async Task<bool> UpdateAsync(Cliente clie)
        {
            using (var conn = _DbConn.Connection)
            {

               var ret =  await conn.UpdateAsync<Cliente>(clie).ConfigureAwait(false);

                return ret;
            }
        }
    }
}
