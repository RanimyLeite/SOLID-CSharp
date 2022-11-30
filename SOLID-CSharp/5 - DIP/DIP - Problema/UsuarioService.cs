using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CSharp._5___DIP.DIP___Problema
{
    public class UsuarioService
    {
        public string AdicionarUsuario(Usuario usuario)
        {
            if (!usuario.IsValid())
                return "Dados inválidos";

            //Dependencia do UsuarioRepository
            var repo = new UsuarioRepository();
            repo.AdicionarUsuario(usuario);

            //Dependencia de EmailService
            EmailServices.Enviar("csharp@solid.com", usuario.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Usuário cadastrado com sucesso";
        }
    }
}
