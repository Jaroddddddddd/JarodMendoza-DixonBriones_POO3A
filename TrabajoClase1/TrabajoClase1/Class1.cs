using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoClase1
{
    class Class1
    {
        private float costo = 0;
        private int horas = 0;
        private float subtotal = 0;
        private float descuento = 0;
        private float subtotal2 = 0;
        private float iva = 0;
        private float final = 0;
        private float pagado=0;
        private float pendiente = 0;
        private string estado = "";
       


        public Class1() { }
        public float Costo {

            get {
                Console.WriteLine("Seleccione la cancha requerida");
                Console.WriteLine("1. Cancha de Futbol");
                Console.WriteLine("2. Cancha de Futbolito");
                Console.WriteLine("3. Cancha de Indor");
                Console.WriteLine("4. Cancha de Básquet");
                int op = int.Parse(Console.ReadLine());
                while (op < 1 || op > 4)
                {
                    Console.WriteLine("La opción ingresada no es validad, reingrese.");
                    op = int.Parse(Console.ReadLine());
                }


                switch (op)
                {

                    case 1:
                        costo = 20;
                        break;
                    case 2:
                        costo = 15;
                        break;
                    case 3:
                        costo = 5;
                        break;
                    case 4:
                        costo = 5;
                        break;
                   
                }
                return costo;
            }

           
        }
        public int Horas
        {
            get
            {
                return horas;
            }
            set
            {
                while (value>3 )
                {
                    Console.WriteLine("NO se hace prestamo mayor a 3 horas");
                    Console.WriteLine("Ingrese las horas del prestamo.");
                    value = int.Parse(Console.ReadLine());
                }
                horas = value;
               
            }

        }
        public float Descuento
        {
            get
            {
                if (descuento == 10)
                {
                    descuento = 10;
                }
                if (descuento == 20)
                {
                    descuento = 20;
                }
                return descuento = (subtotal * descuento) / 100;


            }
            set
            {

                while (value !=10 && value !=20)
                {
                    Console.WriteLine("El descuento debe ser 10 o 20");
                    Console.WriteLine("Ingrese el descuento a aplicar.");
                    value = float.Parse(Console.ReadLine());
                }
               
                descuento = value;
            }
        }

        public float Subtotal
        {
            get
            {
                return subtotal= horas*costo;

            }

        }

        public float Iva
        {
            get
            {
                return iva=(subtotal2*12)/100;

            }
            
        }

        public float Subtotal2
        {
            get
            {
                return subtotal2 = subtotal-descuento ;

            }

        }

        public float Final
        {
            get
            {
                return final = subtotal2 + iva;

            }

        }

        public float Pagado
        {
            get
            {
                
                return pagado;

            }
            set
            {
               
                while (value<(Subtotal*0.5))
                {
                    Console.WriteLine("El anticipo debe ser mayor al 50% del valor a pagar");
                    Console.WriteLine("reingrese el anticipo");
                    value = float.Parse(Console.ReadLine());
                    
                }
                pagado = value;
            }
        }

        public float Pendiente
        {
            get
            {

                return pendiente=Final-Pagado;
            }
            
        }
        public string Estado
        {
            get
            {
                if (Pendiente<0)
                {
                    estado = "PAGADO";

                }

                if (Pendiente > 0)
                {
                    estado = "PENDIENTE";

                }
                return estado;


            }
           

        }
    }
}
