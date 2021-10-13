using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efinance.Models.Dto
{
    [Table("dbo.Cidade")]
    public class Cidade
    {
        [Key]
        public int CidadeId { get; set; }

        public int UfId { get; set; }

        public string NomeCidade { get; set; }

       

    }
}
