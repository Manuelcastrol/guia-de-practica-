using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace EjercicioDeGuia
{
    internal class Empleados: Persona
    {
        public string NombreEmpleado { get; set; }

        public void Empleado()
        {
            WriteLine("Registre el empleado");
            NombreEmpleado = ReadLine();
            TipoContrato tipoContrato = new TipoContrato();
            tipoContrato.Contrato();

   
        }

    }
}
