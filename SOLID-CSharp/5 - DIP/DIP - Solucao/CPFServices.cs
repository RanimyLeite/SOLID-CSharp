using SOLID_CSharp._5___DIP.DIP___Solucao.Interfaces;

namespace SOLID_CSharp._5___DIP.DIP___Solucao
{
    public class CPFServices : ICPFServices
    {
        public bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
