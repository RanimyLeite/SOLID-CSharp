using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CSharp._3___LSP.LSP___Problema
{
    public class Retangulo
    {
        // Classe PAI
        public virtual double Altura { get; set; }
        public virtual double Largura { get; set; }

        //Retorna o calculo da area do Retangulo
        public double Area { get { return Altura * Largura; } }
    }
}
