using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CSharp._4___ISP.ISP___Problema
{
    public class CadastroUsuario : ICadastro
    {
        public void ValidarDados()
        {
            // Validar CPF, Email
        }

        public void Salvar()
        {
            // Insert na tabela Usuario
        }

        public void EnviarEmail()
        {
            // Enviar e-mail para o usuario
        }
    }
}
