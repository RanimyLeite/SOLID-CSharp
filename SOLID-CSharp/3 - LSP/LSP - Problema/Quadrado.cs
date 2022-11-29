using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CSharp._3___LSP.LSP___Problema
{
    public class Quadrado : Retangulo
    {
        //A classe Quadrado herda da classe Retangulo, logo a classe Quadrado é a classe FILHA
        public override double Altura
        {
            // Seta a altura e largura com o mesmo valor
            set { base.Altura = base.Largura = value; }
        }

        public override double Largura
        {
            // Seta a altura e largura com o mesmo valor
            set { base.Altura = base.Largura = value; }
        }
    }
}
