using SOLID_CSharp._4___ISP.ISP___Solucao.Interfaces;

namespace SOLID_CSharp._4___ISP.ISP___Solucao
{
    public class CadastroUsuario : ICadastroUsuario
    {
        public void ValidarDados()
        {
            // Validar CPF, Email
        }

        public void Salvar()
        {
            // Insert na tabela Usuário
        }

        public void EnviarEmail()
        {
            // Enviar e-mail para o usuário
        }
    }
}
