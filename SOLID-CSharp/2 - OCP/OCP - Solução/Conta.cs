using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CSharp._2___OCP.OCP___Solução
{
    public abstract class Conta
    { //Criaremos uma classe abstrata com metodos abstratos
        public int Agencia { get; set; }
        public int NUmeroConta { get; set; }
        public decimal Saldo { get; set; }

        // Criaremos metodos abstratos e a classe que herdar Conta irá sobrescrever esses metodos da maneira que quiser!
        public abstract void Depositar(decimal valor , string conta);
        public abstract void Sacar(decimal valor, string conta);
    }
}
