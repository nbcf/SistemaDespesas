using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conta
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Banco { get; set; }
        public string? Agencia { get; set; }
        public string? NumeroConta { get; set; }
        public string? Digito { get; set; }
        public double Saldo { get; set; }
        public DateTime? Data_Abertura { get; set; }
        public string? Descricao { get; set; }


    }
}
