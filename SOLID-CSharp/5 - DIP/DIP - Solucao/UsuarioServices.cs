using SOLID_CSharp._5___DIP.DIP___Solucao.Interfaces;

namespace SOLID_CSharp._5___DIP.DIP___Solucao
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IEmailServices _emailServices;

        public UsuarioServices(
            IEmailServices emailServices,
            IUsuarioRepository usuarioRepository)
        {
            _emailServices = emailServices;
            _usuarioRepository = usuarioRepository;
        }

        public string AdicionarUsuario(Usuario usuario)
        {
            if (!usuario.IsValid())
                return "Dados inválidos";

            _usuarioRepository.AdicionarUsuario(usuario);

            _emailServices.Enviar("csharp@solid.com", usuario.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Usuário cadastrado com sucesso";
        }
    }
}
