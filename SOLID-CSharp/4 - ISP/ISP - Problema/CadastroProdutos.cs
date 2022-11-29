using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CSharp._4___ISP.ISP___Problema
{
    public class CadastroProduto : ICadastro
    {
        public void ValidarDados()
        {
            // Validar valor
        }

        public void Salvar()
        {
            // Insert tabela Produto
        }

        //Um produto NÃo possui email, logo não precisa desse metodo
        public void EnviarEmail()
        {
            // Produto não tem e-mail
            // Qual deverá ser a implementação?
        }
    }
}
