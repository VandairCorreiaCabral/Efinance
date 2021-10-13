using Efinance.Models.DataBase;
using Efinance.Models.Dto;
using Efinance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Efinance.Repositories.Services
{
    public class EstadoService : IEstadoService
    {

        private readonly DbConexao _DbConn;
        public EstadoService(DbConexao DbConn)
        {
            _DbConn = DbConn;
        }

        public async Task<int> AddAsync(Uf uf)
        {
            using (var conn = _DbConn.Connection)
            {

               var ret =    await conn.InsertAsync<Uf>(uf).ConfigureAwait(false);

                return ret;
            }

           
        }

        public async Task<IEnumerable<Uf>> GetAllAsync()
        {
            using (var conn = _DbConn.Connection)
            {

                IEnumerable<Uf> _Uf = await conn.GetAllAsync<Uf>().ConfigureAwait(false);

                return _Uf;
            }
        }

        public async Task<Uf> GetAsync(int id)
        {
            using (var conn = _DbConn.Connection)
            {

                Uf uf = await conn.GetAsync<Uf>(id);
                return uf;

            }
        }

        public async Task<bool> Remove(int id)
        {
            using (var conn = _DbConn.Connection)
            {

               var ret = await conn.DeleteAsync<Uf>(new Uf() { UfId = id });
                return ret;
               
            }
        }

        public async Task<bool> UpdateAsync(Uf uf)
        {
            using (var conn = _DbConn.Connection)
            {

               var ret = await conn.UpdateAsync<Uf>(uf).ConfigureAwait(false);

                return ret;
            }
        }
    }
}
