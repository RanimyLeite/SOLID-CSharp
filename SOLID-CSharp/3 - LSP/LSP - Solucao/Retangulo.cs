using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CSharp._3___LSP.LSP___Solucao
{
    public class Retangulo : Paralelogramo
    {
        // O construtor do retangulo recebe as infos de Altura, Largura e chama a classe PAI (Paralelogramo) passando essas infos
        public Retangulo(int altura, int largura)
            : base(altura, largura)
        {

        }
    }
}
