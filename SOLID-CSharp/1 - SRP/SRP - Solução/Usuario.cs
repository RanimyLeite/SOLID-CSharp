using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CSharp._1___SRP.SRP___Solução
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public bool IsValid()
        {
            // EmailService e CPFServices são responsaveis por validar email e cpf
            return EmailServices.IsValid(Email) && CPFServices.IsValid(CPF);
        }
    }
}
