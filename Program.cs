/*

Nombre: Winston Emill Pichardo Rodríguez
ID: 1115997
Materia: Tecnología de los objetos.

Tarea: Ejercicio Práctico

    Construya una definición de clase que pueda usarse para representar a un empleado de una compañía.
    Cada empleado es definido por un número entero de identificación, una tasa salarial en punto flotante
    y el número máximo de horas que el empleado debería trabajar cada semana. Los servicios de la clase deberán proporcionar
    la capacidad para introducir datos, cambiar datos y desplegar los datos existentes para un empleado nuevo.

    Incluir un menú que ofrezca al usuario las siguientes opciones:
        1. Agregar un empleado
        2. Modificar los datos del empleado
        3. Eliminar a un empleado
        4. Salir de este menú

    En respuesta a una opción el programa deberá iniciar la acción apropiada para implementar la opción.

*/

using System;
using System.Collections.Generic;
using Cuenta;

// Programa
public class Program
{
    static void Main(string[] args)
    {
        List<Empleado> empleados = new List<Empleado>();

        Empleado empleado = null;

        int opcion = 0;

        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Agregar un empleado");
            Console.WriteLine("2. Modificar los datos del empleado");
            Console.WriteLine("3. Eliminar a un empleado");
            Console.WriteLine("4. Desplegar los datos de los empleados.");
            Console.WriteLine("5. Salir.");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    empleado = new Empleado(0, 0, 0);
                    empleado.IntroducirDatos();
                    empleados.Add(empleado);
                    Console.WriteLine("Empleado agregado exitosamente.");
                    break;
                case 2:
                    Console.Write("Introduzca el número de identificación del empleado a modificar: ");
                    int idModificar = int.Parse(Console.ReadLine());
                    Empleado empleadoModificar = empleados.Find(e => e.ID == idModificar);
                    if (empleadoModificar != null)
                    {
                        empleadoModificar.ModificarDatos();
                        Console.WriteLine("Empleado modificado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró un empleado con ese número de identificación.");
                    }
                    break;
                case 3:
                    Console.Write("Introduzca el número de identificación del empleado a eliminar: ");
                    int idEliminar = int.Parse(Console.ReadLine());
                    Empleado empleadoEliminar = empleados.Find(e => e.ID == idEliminar);
                    if (empleadoEliminar != null)
                    {
                        empleados.Remove(empleadoEliminar);
                        Console.WriteLine("Empleado eliminado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró un empleado con ese número de identificación.");
                    }
                    break;
                case 4:
                    foreach (Empleado e in empleados)
                    {
                        e.DesplegarDatos();
                        Console.WriteLine();
                    }
                    break;
                case 5:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}