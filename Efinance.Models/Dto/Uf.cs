using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efinance.Models.Dto
{
    [Table("dbo.Uf")]
    public class Uf
    {
        [Key]
        public int UfId { get; set; }

        public string CodigoIBGE { get; set; }

        public string Estado { get; set; }

        public string Sigla { get; set; }

        public string CodigoBacen { get; set; }

        public string Pais { get; set; }

    }

}
