using System;

namespace Aula11_Sprint4_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo infoPlayer = new Calculo();
            //1° opção, sem argumentos
            System.Console.WriteLine( infoPlayer.Calcular());

            //2° opção, com 1 argumento int
            System.Console.WriteLine(infoPlayer.Calcular(100));

            //3° opção, com 2 argumentos int
            System.Console.WriteLine(infoPlayer.Calcular(100, 40));

            //4° opção, com 2 argumentos string
            System.Console.WriteLine(infoPlayer.Calcular("Big","John"));
        }
    }
}
