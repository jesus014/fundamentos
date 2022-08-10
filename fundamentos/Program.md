# Program.cs


```csharp

namespace fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("coca", 100);
            bebida.Beberse(50);
            Console.WriteLine(bebida.Nombre);
            Console.WriteLine(bebida.Cantidad);


            Cerveza cerveza = new Cerveza(20);
            Console.WriteLine(cerveza.Nombre);
            cerveza.Beberse(12);
            Console.WriteLine(cerveza.Cantidad);

            int[] numeros = new int[2];
            int[] numeross = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(i);
            }

            foreach (var item in numeross)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            lista.Add(9);
            lista.Add(0);
            lista.Remove(2);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza(20) };
            cervezas.Add(new Cerveza(500));
            Cerveza cheve = new Cerveza(500, "cerveza artesanalk");
            cervezas.Add(cheve);

            foreach (var item in cervezas)
            {
                Console.WriteLine(item.Cantidad);
                Console.WriteLine(item.Nombre);
            }


            var bebidaAlcoholica = new vino(100);
            MostrarRecomendacion(bebidaAlcoholica);

            CervezaBD cervezaBD = new CervezaBD();
            var cervezas1 =  cervezaBD.Get();

            foreach (var ce in cervezas1)
            {
                Console.WriteLine(ce.Nombre);
            }
        

        }
            static void MostrarRecomendacion(IBebidaAlcoholica bebida)
            {
                bebida.MaxRecomendado();
            }


    }
}
```
