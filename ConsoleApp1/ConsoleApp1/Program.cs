using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Resta(int a, int b)
        {
            return a - b;
        }
        static int Mult(int a, int b)
        {
            return a * b;
        }
        static int Div(int a, int b)
        {
            return a / b;
        }
        static void Prim()
        {
            int contador = 0;
            int primos = 0;
            int inicializador = 1;
            do {
                inicializador++;
                for (int i = 2; i < inicializador; i++)
                {
                    if (inicializador % i == 0)
                    {
                        contador++;
                        break;
                    } 
                }
                if (contador == 0)
                {
                    Console.WriteLine(inicializador);
                    primos++;
                }
                contador = 0;
            } while (primos <= 10);
            Console.ReadKey();
        }
        static double Celsius(double a)
        {
            return (5 * (a - 32)) / 9;
        }

        static double Fahrenheit(double a)
        {
            return ((9 * a) / 5) + 32;
        }
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es {1}", i, Math.Sqrt(i));
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y Funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] SUMA DE DOS NUMEROS");
                Console.WriteLine("[2] IMPRIMIR LA RAIZ CUADRADA DE LOS PRIMEROS NUMEROS ENTEROS");
                Console.WriteLine("[3] RESTA DE DOS NUMEROS");
                Console.WriteLine("[4] MULTIPLICACION DE DOS NUMEROS");
                Console.WriteLine("[5] DIVISION DE DOS NUMEROS");
                Console.WriteLine("[6] 10 PRIMEROS NUMEROS PRIMOS");
                Console.WriteLine("[7] FAHRENHEIT A CELSIUS");
                Console.WriteLine("[8] CELSIUS A FAHRENHEIT");
                Console.WriteLine("[0] SALIR");
                Console.WriteLine("Ingrese una Opcion y Presione Enter");
                opcion = Console.ReadLine();
                double cel;
                double fare;
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese El primer Numero");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese El Segundo Numero");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a,b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando ......");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese El primer Numero");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese El Segundo Numero");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es: {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese El primer Numero");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese El Segundo Numero");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Multiplicacion de {0} y {1} es: {2}", e, f, Mult(e, f));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese El primer Numero");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese El Segundo Numero");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La Division de {0} y {1} es: {2}", g, h, Div(g, h));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Estos son los 10 primeros numeros primos:");
                        Prim();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese el valor de Fahrenheit");
                        fare = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(" {0} grados en Fahrenheits son {1} grados en Celsius", fare, Celsius(fare));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese el valor de Celsius");
                        cel = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(" {0} grados en Celsius son {1} grados en Fahrenheits", cel, Fahrenheit(cel));
                        Console.ReadKey();
                        break;

                }
            } while (!opcion.Equals("0"));
        }
    }
}
