using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Movimento
    {
        public int Id { get; set; }
        public string? Tipomov { get; set; }
        public double Valor { get; set; }
        public DateTime? Datamovimento { get; set; }
        public string? Horamovimento { get; set; }
        public int Idconta { get; set; }

    }
}
