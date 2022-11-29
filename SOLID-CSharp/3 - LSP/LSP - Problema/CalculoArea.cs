using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CSharp._3___LSP.LSP___Problema
{
    public class CalculoArea
    {
        private static void ObterAreaRetangulo(Retangulo ret)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(ret.Altura + " * " + ret.Largura);
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quad = new Quadrado()
            {
                Altura = 10,
                Largura = 5
            };

            //Nesse Momento estamos fazendo a substituição da classe pai pela classe filha
            // Pois a classe pai é um Retangulo mas eu estou mandando um quadrado!
            ObterAreaRetangulo(quad);

            //OBS! O Resultado irá ser 5*5 = 25 pois na classe quadrado é feita uma sobrescrita de forma errada!
        }
    }
}
