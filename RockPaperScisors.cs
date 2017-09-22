using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScisors
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta, situacion = 1, Casos;
            while (true)
            {
                try
                {
                    String[] arr = { "Tijera", "papel", "piedra" };
                    Random eleccion = new Random();
                    int a = eleccion.Next(1, 3);
                    String ele = arr[a - 1];
                    Console.Clear();
                    Console.WriteLine("Vamos a jugar piedra papel o tijera:");
                    Console.WriteLine("1) Tijera.");
                    Console.WriteLine("2) Papel.");
                    Console.WriteLine("3) Piedra.");
                    Console.Write("Ingresa el número de tu elección: ");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("La computadora eligió {0}",ele);
                    if (a==respuesta)

                       situacion = 1;                                       //1 = empate, 2 = ganaste, 3 = perdiste

                    else if (a==(1) && respuesta == 3)

                        situacion = 2;

                    else if (a==1 && respuesta == 2)

                        situacion = 3;

                    else if (a==(2) && respuesta == 1)

                        situacion = 2;

                    else if (a==(2) && respuesta == 3)

                        situacion = 3;

                    else if (a==(3) && respuesta == 1)

                        situacion = 3;

                    else if (a==(3) && respuesta == 2)

                        situacion = 2;

                    Casos = situacion;
                    switch (Casos)
                    {
                        case 1:
                            Console.WriteLine("Empate!!");
                            break;
                        case 2:

                            Console.WriteLine("Ganaste!!");
                            break;
                        case 3:

                            Console.WriteLine("Perdiste!!!");
                            break;
                    }
                    Console.WriteLine("Deseas jugar otra vez? :");
                    Console.WriteLine("a)Sí");
                    Console.WriteLine("b)No");
                    String r = Console.ReadLine();
                    if (r == "b")
                        break;
                    else if (r == "a")
                        Console.Write("");
                    else
                        Console.WriteLine("Error, dato invalido");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error, no ingresaste un número");
                }
                finally
                {
                    Console.Write("Presiona una tecla para continuar");
                    Console.ReadKey();
                }
            }
        }
    }
}
