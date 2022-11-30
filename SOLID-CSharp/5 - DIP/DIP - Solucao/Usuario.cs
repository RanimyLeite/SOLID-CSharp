using SOLID_CSharp._5___DIP.DIP___Solucao.Interfaces;
using System;

namespace SOLID_CSharp._5___DIP.DIP___Solucao
{
    public class Usuario
    {
        private readonly ICPFServices _cpfServices;
        private readonly IEmailServices _emailServices;

        public Usuario(
            ICPFServices cpfServices,
            IEmailServices emailServices)
        {
            _cpfServices = cpfServices;
            _emailServices = emailServices;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public bool IsValid()
        {
            // Aqui não dependemos mais da classe concreta(EmailService) mas sim a sua abstração(IEmailServices).
            return _emailServices.IsValid(Email) && _cpfServices.IsValid(CPF);
        }
    }
}
