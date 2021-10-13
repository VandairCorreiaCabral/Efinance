using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfinanceFront.Models
{

    public class Cliente
    {
        public int ClienteId { get; set; }

        public string CpfCnpj { get; set; }

        public string Email { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }

        public int CidadeId { get; set; }

    }
}
