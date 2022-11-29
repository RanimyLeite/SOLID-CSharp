using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CSharp._3___LSP.LSP___Solucao
{
    public class Quadrado : Paralelogramo
    {
        // O construtor do quadrado recebe as infos de Altura, Largura e chama a classe PAI (Paralelogramo) passando essas infos
        // Valida se as infos de altura e largura são diferentes
        public Quadrado(int altura, int largura)
            : base(altura, largura)
        {
            if (largura != altura)
                throw new ArgumentException("Os dois lados do quadrado precisam ser iguais");
        }
    }
}
