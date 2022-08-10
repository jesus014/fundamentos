// See https://aka.ms/new-console-template for more information
using fundamentos.Models;
using System.Text.Json;

namespace fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {

            //CervezaBD cervezaBD = new CervezaBD();
            ////agregar datos 
            //{
            //    //los dos primeros datos estan en el constructor

            //    Cerveza cerveza = new Cerveza(20, "tecate");
            //    cerveza.Marca = "otra";
            //    cerveza.Alcohol = 5;
            //    cervezaBD.Add(cerveza);

            //}

            ////editar cerveza
            //{

            //    Cerveza cerveza = new Cerveza(20, "tecate");
            //    cerveza.Marca = "otra";
            //    cerveza.Alcohol = 20;
            //    cervezaBD.Edit(cerveza, 4);
            //}


            ////obtener datos
            //var cervezas = cervezaBD.Get();
            //foreach (var ce in cervezas)
            //{
            //    Console.WriteLine(ce.Nombre);
            //    Console.WriteLine(ce.Cantidad);
            //}

            ////eliminar
            //{


            //    cervezaBD.Delete(4);
            //}

           
                
            
            //Cerveza cerveza = new Cerveza(10, "cerzveza");
            //string miJson = JsonSerializer.Serialize(cerveza);
            //File.WriteAllText("objeto.txt", miJson);

            string miJson= File.ReadAllText("objeto.txt");
            Cerveza cerveza=JsonSerializer.Deserialize<Cerveza>(miJson);


        }

    }
}