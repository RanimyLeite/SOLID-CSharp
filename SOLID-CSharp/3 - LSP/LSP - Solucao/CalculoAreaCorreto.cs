using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CSharp._3___LSP.LSP___Solucao
{
    public class CalculoAreaCorreto
    {
        private static void ObterAreaParalelogramo(Paralelogramo par)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Paralelogramo");
            Console.WriteLine();
            Console.WriteLine(par.Altura + " * " + par.Largura);
            Console.WriteLine();
            Console.WriteLine(par.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {

            var ret = new Retangulo(20, 30);
            ObterAreaParalelogramo(ret);

            // Retorna a exception pois nesse caso a altura e largura não são iguais
            //var quadErro = new Quadrado(10, 5);
            //ObterAreaParalelogramo(quadErro);

            // Retorna sucesso pois nesse caso a altura e largura são iguais
            //var quadSucesso = new Quadrado(10, 10);
            //ObterAreaParalelogramo(quadSucesso);
        }
    }
}
