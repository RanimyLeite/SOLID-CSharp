using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CSharp._2___OCP.OCP___Solução
{
    public class ContaCorrente : Conta
    {
        private decimal TaxaMovimentacao;

        public ContaCorrente()
        {
            this.TaxaMovimentacao = 0.01m;
        }

        // Iremos sobrescrever o método usando o override e criar o comportamento do método para esse tipo de conta!
        public override void Sacar(decimal valor, string conta)
        {
            this.Saldo -= (valor + (valor * TaxaMovimentacao));
        }

        public override void Depositar(decimal valor, string conta)
        {
            this.Saldo += valor;;
        }
    }
}
