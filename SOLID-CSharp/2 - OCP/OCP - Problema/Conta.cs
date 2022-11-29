using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CSharp._2___OCP.OCP___Problema
{
    public class Conta
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public TipoConta TipoConta { get; set; }
    }
}
