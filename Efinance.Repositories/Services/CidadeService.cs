using Dapper.Contrib.Extensions;
using Efinance.Models.DataBase;
using Efinance.Models.Dto;
using Efinance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efinance.Repositories.Services
{
    public class CidadeService : ICidadeService
    {
        private readonly DbConexao _DbConn;
        public CidadeService(DbConexao DbConn)
        {
            _DbConn = DbConn;
        }

        public async Task<int> AddAsync(Cidade cit)
        {
            using (var conn = _DbConn.Connection)
            {

                var ret = await conn.InsertAsync<Cidade>(cit).ConfigureAwait(false);

                return ret;
            }


        }

        public async Task<IEnumerable<Cidade>> GetAllAsync()
        {
            using (var conn = _DbConn.Connection)
            {

                IEnumerable<Cidade> _Cidade = await conn.GetAllAsync<Cidade>().ConfigureAwait(false);

                return _Cidade;
            }
        }

        public async Task<Cidade> GetAsync(int id)
        {
            using (var conn = _DbConn.Connection)
            {

                Cidade cidadef = await conn.GetAsync<Cidade>(id);
                return cidadef;

            }
        }

        public async Task<bool> Remove(int id)
        {
            using (var conn = _DbConn.Connection)
            {

                var ret = await conn.DeleteAsync(new Cidade() { CidadeId = id });
                return ret;

            }
        }

        public async Task<bool> UpdateAsync(Cidade cit)
        {
            using (var conn = _DbConn.Connection)
            {

               var ret = await conn.UpdateAsync<Cidade>(cit).ConfigureAwait(false);

                return ret;
            }
        }
    }
}
