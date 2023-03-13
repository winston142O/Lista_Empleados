using System;

namespace Cuenta
{
    public class Empleado
    {

        private int id;
        private double tasaSalario;
        private int horasSemanales;

        public Empleado(int id, double tasaSalario, int horasSemanales)
        {
            this.id = id;
            this.tasaSalario = tasaSalario;
            this.horasSemanales = horasSemanales;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public double TasaSalario
        {
            get { return tasaSalario; }
            set { tasaSalario = value; }
        }

        public int HorasSemanales
        {
            get { return horasSemanales; }
            set { horasSemanales = value; }
        }

        public void IntroducirDatos()
        {
            Console.Write("Introduzca el número de identificación: ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("Introduzca la tasa salarial: ");
            TasaSalario = double.Parse(Console.ReadLine());
            Console.Write("Introduzca el número máximo de horas semanales: ");
            HorasSemanales = int.Parse(Console.ReadLine());
        }

        public void ModificarDatos()
        {
            Console.Write("Introduzca la nueva tasa salarial: ");
            TasaSalario = double.Parse(Console.ReadLine());
            Console.Write("Introduzca el nuevo número máximo de horas semanales: ");
            HorasSemanales = int.Parse(Console.ReadLine());
        }

        public void DesplegarDatos()
        {
            Console.WriteLine($"----- Empleado {ID} -----");
            Console.WriteLine("Número de identificación: {0}", ID);
            Console.WriteLine("Tasa salarial: {0}", TasaSalario);
            Console.WriteLine("Número máximo de horas semanales: {0}", HorasSemanales);
        }
    }
}