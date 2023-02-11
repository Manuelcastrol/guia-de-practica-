using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EjercicioDeGuia
{
    internal class Inmueble:Cliente
    {
        public string tipo { get; set; }


        public void TiposInmuebles() 
        {
            Empleados empleados = new Empleados();
            WriteLine("Escoje el tipo de inmueble que deseas\n 1- Inmueble urbano \n 2- Rustico \n 3- Por naturaleza \n 4- Por incorporación");
            int opcion = int.Parse(ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = "casa";
             
                    empleados.Empleado();
                    break;

                case 2:
                    tipo = "escalera";
                    empleados.Empleado();
                    break;

                case 3:
                    tipo = "silla";
                    empleados.Empleado();
                    break;


                case 4:
                    tipo = "mesas";
                    empleados.Empleado();
                    break;

                default:
                    WriteLine("No, no existe esa opcion");
                    break;
            }
        }
    }
        
}

