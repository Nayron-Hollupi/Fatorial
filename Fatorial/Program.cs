using System;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resposta;

            Console.WriteLine("Informe um valor: ");
            numero = int.Parse(Console.ReadLine());

            resposta = fatorial(numero);

            Console.WriteLine("O Fatorial de {0} eh : {1}", numero, resposta);


          
        }

      static int fatorial(int numero)
        {
           
            return (numero <= 1) ? 1 : (numero * fatorial(numero - 1));
        }
       
    }
}
