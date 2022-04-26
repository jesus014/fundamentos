// See https://aka.ms/new-console-template for more information
using fundamentos.Models;

namespace fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("coca",100);
            bebida.Beberse(50);
            Console.WriteLine(bebida.Nombre);
            Console.WriteLine(bebida.Cantidad);


            Cerveza cerveza = new Cerveza();
            Console.WriteLine(cerveza.Nombre);
            cerveza.Beberse(12);
            Console.WriteLine(cerveza.Cantidad);

            int[] numeros = new int[2];
            int[] numeross = new int[] { 1,2,3,4,5,6,7,8 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}