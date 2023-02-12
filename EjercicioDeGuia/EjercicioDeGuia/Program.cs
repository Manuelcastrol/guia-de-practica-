using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EjercicioDeGuia
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            Empleados date = new Empleados();

            WriteLine("ALQUILAR \n");

            WriteLine(" DATOS DEL VENDEDOR \n PRESIONE ENTER");
            string texto = ReadLine();
            WriteLine(" EMPLEADO");
            WriteLine($" NOMBRE: {date.nombre} APELLIDO: {date.apellido} EDAD: {date.edad} \n CARGO: {date.cargo} \n");
           
            WriteLine("INGRESE LOS DATOS DEL CLIENTE \n PRESIONE ENTER");
            string Cliente = ReadLine();

            Cliente clien = new Cliente();

            WriteLine("PORFAVOR INGRESE EL DUI ");
            clien.Dui = ReadLine();
            WriteLine("PORFAVOR INGRESE EL NOMBRE ");
            clien.nombre = ReadLine();
            WriteLine("PORFAVOR INGRESE EL APELLIDO ");
            clien.apellido = ReadLine();
            WriteLine("PORFAVOR INGRESE EL NUMERO DE TELEFONO ");
            clien.telefono = ReadLine();
            WriteLine("PORFAVOR INGRESE LA DIRRECCION ");
            clien.direccion = ReadLine();
            WriteLine("los datos ingresados son: \n" + "DUi:"+clien.Dui + "\n" +"CLIENTE NOMBRE:"+ clien.nombre+ "\n"+ "CLIENTE APELLIDO:"+ clien.apellido +"\n"+ "TELEFONO:" + clien.telefono + "\n" + "DIRRECCION:" + clien.direccion);
            string datos = ReadLine();

            inmueble inmue = new inmueble();
            WriteLine("PORFAVOR INGRESE EL INMUEBLE ");
            inmue.tipo_inmueble = ReadLine();
            WriteLine("\n");

            Empleados emplea = new Empleados();

            TipoContrato contrato = new TipoContrato();

            WriteLine(" \n CON TIPO DE CONTRATO \n" + "DUi CLIENTE:"+ clien.Dui+ "\n" + "NOMBRE CLIENTE:" + clien.nombre+ "\n" + "NOMBRE EMPLEADO:"+emplea.nombre+ "" + "CARGO DEL EMPLREADO:"+emplea.cargo+ "" + "INMUEBLE:" + inmue.tipo_inmueble+ "\n" + "DIRECCION" + contrato.direcionInmu+ ""+ "CARACTERISTICAS" + contrato.caracteristicas+ ""+ "PAGO" + contrato.formaPago);
            string contra = ReadLine();

        }
    }

    public class Empleados
    {
        public string id;
        public string nombre = " Juan \n";
        public string apellido = " Hernandez \n";
        public string cargo = "Sub Gerente \n";
        public int edad = 34;

    }

    public class Cliente
    {
        private string dui;
        public string Dui
        {
            get { return dui; }
            set { dui = value; }
        }

        public string nombre;
        public string apellido;
        public string telefono;
        public string direccion;
    }

    public class inmueble
    {
        public string tipo_inmueble;
    }


    public class TipoContrato
    {
        public string cliente;
        public string direcionInmu = ": 2Av. al norte, calle el centro, barrio la vega, el paraiso, Chalatenango \n";
        public string caracteristicas = ": Alquiler de casas, departamentos, eventos, iglecias u hoteles \n";
        public string formaPago = ": Bancaria ";



    }

    public class metodos : Cliente
    {
        public void information()
        {


            Cliente date = new Cliente();

            WriteLine("Ingrese los datos del cliente");
            WriteLine("DUI");
            date.Dui = ReadLine();
            WriteLine("Nombre");
            date.nombre = ReadLine();
            WriteLine("Apellido");
            date.apellido = ReadLine();
            WriteLine("Telefono");
            date.telefono = ReadLine();
            WriteLine("Direccion");
            date.direccion = ReadLine();
            string recoleccionDatosClientes = ReadLine();
        }

    }
}