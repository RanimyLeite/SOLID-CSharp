using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CSharp._1___SRP.SRP___Solução
{
    public class UsuarioService
    {
        public string AdicionarUsuario(Usuario usuario)
        {
            if (!usuario.IsValid())
                return "Dados inválidos";

            // Instancia o Repository e cria o user no banco
            var repo = new UsuarioRepository();
            repo.AdicionarUsuario(usuario);

            // Cria e envia o email
            EmailServices.Enviar("csharp@solid.com", usuario.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Usuário cadastrado com sucesso";
        }
    }
}
