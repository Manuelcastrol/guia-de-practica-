using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EjercicioDeGuia
{
    internal class Cliente : Persona
    {
       
        public void Compra()
        {
            try
            {
                WriteLine("Por favor digite su nombre");
                nombre = ReadLine();
                WriteLine("Por favor digite su numero de DUI");
                dui = int.Parse(ReadLine());
                Inmueble inmueble = new Inmueble();
                inmueble.TiposInmuebles();
            }
            catch (Exception e)
            {

                WriteLine($"Error {e.Message}");
            }




        }

    }
}
