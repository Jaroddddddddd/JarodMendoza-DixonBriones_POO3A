using System;

namespace TrabajoClase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Class1 = new Class1();
            Console.WriteLine("Costo: "+Class1.Costo);
            Console.WriteLine("Ingrese las horas del prestamo.");
            Class1.Horas = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese el descuento a aplicar");
            Class1.Descuento = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el anticipo");
            Class1.Pagado = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("______________________________________________");

            Console.WriteLine("Subtotal: "+Class1.Subtotal);
            Console.WriteLine("Descuento: "+Class1.Descuento);
            Console.WriteLine("Subt. con Descuento: " + Class1.Subtotal2);
            Console.WriteLine("IVA: "+Class1.Iva);
            Console.WriteLine("Valor Final: "+Class1.Final);
            Console.WriteLine("Pagado: "+Class1.Pagado);
            Console.WriteLine("Saldo Pendiente: "+Class1.Pendiente);
            Console.WriteLine("Estado: "+Class1.Estado);
            Console.WriteLine("______________________________________________");

        }
    }
}
