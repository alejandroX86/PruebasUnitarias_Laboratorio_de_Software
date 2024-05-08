using System;
// hago el main para los calculos

namespace primer_parcial_unit_test_procesador_matematico
{
    class Program
    {
        static void Main(string[] args)
        {
            


            ProcesadorMatematico procesador = new ProcesadorMatematico();

            
            procesador.Sumar(5, 3);
            Console.WriteLine("Resultado de la suma: " + procesador.GetResultado());

            
            procesador.Dividir(10, 2);
            Console.WriteLine("Resultado de la división: " + procesador.GetResultado());

            
            procesador.CalcularMayor(7, 12);
            Console.WriteLine("Resultado del cálculo del mayor: " + procesador.GetResultado());

            
            Console.ReadLine();




        }
    }
}
