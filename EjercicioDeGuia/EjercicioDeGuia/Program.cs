using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EjercicioDeGuia
{
    internal class Program : Empleados
    {
        static void Main(string[] args)
        {

          

            WriteLine("Opciones\n 1- Inmuebles \n 2- Salir" );
            int opcion = int.Parse( ReadLine());

            switch (opcion)
            {

                case 1:
                    Cliente cliente = new Cliente();
                    cliente.Compra();

                    break; 
                default:
                    WriteLine("Lo siento esa opcion no esta disponible");
                    ReadLine();
                   
                    break;
            }


        }
    }
}
