using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EjercicioDeGuia
{
    internal class TipoContrato : Empleados
    {
        public string contrato { get; set; }
      



        public void Contrato()
        {
            WriteLine("Qué tipo de contrato desea seleccionar");
            contrato = ReadLine();

            WriteLine($"\nNombre del cliente: {nombre} DUI: {dui} \n " +
                $"Tipo de inmueble{tipo}\n Empleado a cargo: {NombreEmpleado}\n" +
                $" Tipo de contrato: {contrato}");
            ReadLine();
        }

    }
}
