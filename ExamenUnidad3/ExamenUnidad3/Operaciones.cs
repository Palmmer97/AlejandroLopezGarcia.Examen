using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ExamenUnidad3
{
    public class Operaciones
    {
        
            
            Queue Cola = new Queue();

        

        public void Ejercicio1()
        {
            Stack Lista = new Stack();
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()
            foreach (var item in Lista)
            {
               Console.WriteLine(item); 
            }
            Console.ReadKey();
            Console.WriteLine("Pulse Alguna tecla");
            Console.ReadKey();

            Lista.Push(5);
            Lista.Push(3);
            Lista.Pop();
            Lista.Push(2);
            Lista.Push(8);
            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine("Pulse Alguna tecla");
            Console.ReadKey();
            Lista.Pop();
            Lista.Pop();
            Lista.Push(9);
            Lista.Push(1);
            Lista.Pop();
            Lista.Push(7);
            Lista.Push(6);
            Lista.Pop();
            Lista.Pop();
            Lista.Push(4);
            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Pulse Alguna tecla");
            Console.ReadKey();
            Lista.Pop();
            Lista.Pop();
            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Pulse Alguna tecla");
            Console.ReadKey();


        }

        public void Ejercicio2()
        {
            Console.Clear();
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal
            LinkedList<string> List = new LinkedList<string>();

        }

        public void Ejercicio3()
        {
            Console.Clear();
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            List<int> ListNorm = new List<int>();
            LinkedList<int> ListLiga = new LinkedList<int>();
            Stopwatch Tiem = Stopwatch.StartNew();
            for (int i = 0; i < 9876; i++)
            {
                ListNorm.Add(i);
            }
            Console.Write("tiempo En lista Normal: " + Tiem.Elapsed.TotalMilliseconds.ToString() + "\n");
            Stopwatch Tiem2 = Stopwatch.StartNew();
            for (int i = 0; i < 9876; i++)
            {
                ListLiga.AddLast(i);
            }
            Console.Write("Tiempo ListaLigada:" + Tiem2.Elapsed.TotalMilliseconds.ToString() + "\n");
            Console.WriteLine("pulse una tecla");
            Console.ReadKey();
        }

        public void Ejercicio4()
        {
            Console.Clear();
            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.
            maestro();
            Media();
            CalisBajaAlta();
        }
        List<Alum> Alum = new List<Alum>();
        List<int> Califica = new List<int>();
    public void maestro()
            {
                Clase Clas = new Clase();
                Console.Write("Introduzca su nombre Maestro: ");
                Clas.Maestro = Console.ReadLine();
                Console.Write("\nQue Materia Imparte: ");
                Clas.NombreClase = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Excelente vamos a calificar a los alumnos");
                for (int i = 0; i < 30; i++)
                {
                    Alum Alum1 = new Alum();
                    Console.Write("\n Introduzca el nombre del alumno {0}: ", i);
                    Alum1.Alumno = Console.ReadLine();
                    Console.Write("Calificacion del alumno {0}: ", i);
                    Alum1.Calificacion = int.Parse(Console.ReadLine());
                    Alum.Add(Alum1);

                }
            }
    double SumCalificacion = 0;
    double Promedio = 0;
    public void Media()
    {
        foreach (var item in Alum)
        {
            SumCalificacion = SumCalificacion + item.Calificacion;
            Promedio = SumCalificacion / Alum.Count();
        }
        Console.WriteLine("Promedio:{0} ", Promedio);
        Console.WriteLine("\n Pulse una tecla");
        Console.ReadKey();
    }
    public void CalisBajaAlta()
    {
        foreach (var item in Alum)
        {
            Califica.Add(item.Calificacion);
        }
        Califica.Sort();
        Console.WriteLine("Calificacion alta: " + Califica[29]);
        Console.WriteLine("Calificacion baja: " + Califica[0]);
        Console.WriteLine("\n Pulse una tecla");
        Console.ReadKey();
    }

    }
}
