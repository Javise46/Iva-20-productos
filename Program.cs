using System;

namespace Iva_20_productos
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Nombre = new String[20];
            double[] Iva = new double[20];
            int op;
           
            
            for (op=0; op<19; op++) 
            {
                Console.WriteLine("_________________________________________");
                Console.WriteLine("Nombre Del Producto");
                Nombre[op] = Console.ReadLine();
                Console.WriteLine("Valor Del Producto");
                Iva[op] = double.Parse(Console.ReadLine()) * 0.12; 
                Console.WriteLine("_________________________________________");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
            }
            Console.WriteLine("_________________________________________");
            for (op = 0; op < 19; op++)
            {
                Console.WriteLine(Nombre[op] +" contiene de iva: "+ Iva[op]);
                Console.WriteLine("_________________________________________");
                System.Threading.Thread.Sleep(500);
            }
            
            Console.ReadKey();

        }
    }
}
