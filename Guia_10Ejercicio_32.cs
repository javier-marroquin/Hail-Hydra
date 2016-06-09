using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_10Ejercicio_32
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[100];
            int[] carreras = new int[nombres.Length];
            string bandera;
            int i=0;
            do
            {
                Console.WriteLine("=================================================");
                Console.Write("\nIngrese el Nombre del estudiante: ");
                nombres[i] = Console.ReadLine();
                Console.WriteLine("\nCarrera del estudiante:\n\n1:Arquitectura \n2:Ing. Industrial \n3:Ing. Civil \n4:Ing. Quimica \n5:Ing. de Alimentos \n6:Ing. Electrica \n7:Ing. Mecanica \n8:Ing. de Sistemas Informaticos\n");
                int o = 0;
                do
                {
                    if (o > 0)
                    {
                        Console.WriteLine("===========Error.===========\n");
                        Console.WriteLine("Ingrese nuevamente el dato");
                    }
                    carreras[i] = int.Parse(Console.ReadLine());
                    o++;
                } while (!(carreras[i] > 0 && carreras[i] <= 8));

                //QUERIA Q LOS CASOS DEL SWITH SE ME GUARDARAN EN VECTOR CARRERAS Y NO PUDE ES POSIBLE???                
                Console.WriteLine("\nTiene otro estudiante que procesar precione ''Enter''\nCaso contrario precione ''F''");
                bandera = Console.ReadLine().ToUpper();
                Console.Clear();
                i++;
            } while (bandera != "F");

            MetodoBurbuja(nombres, carreras, i);

            
            //Console.WriteLine(" La carrera"+ metodo.(carreras)+"tiene inscritos:"+nombres);
            // TAMPOCO ME SALE LA IMPRESION INTENTE IMPRIMIR DIRECTAMENTE DEL METODO Y NO SE VOY A INTENTAR HACERLO COMO MEDIO DIJO  EL ING A VER SI LLEGO A ALGO /-\  
            
        }


        public static string Carreras(int num)
        {
            string carrera = null;                        
            switch (num)
            {
                case 1:
                    carrera = "Arquitectura";
                    break;
                case 2:
                    carrera = "Ing. Industrial";
                    break;
                case 3:
                    carrera = "Ing. Civil";
                    break;
                case 4:
                    carrera = "Ing. Quimica";
                    break;
                case 5:
                    carrera = "Ing. de Alimentos";
                    break;
                case 6:
                    carrera = "Ing. Electrica";
                    break;
                case 7:
                    carrera = "Ing. Mecanica";
                    break;
                case 8:
                    carrera = "Ing. de Sistemas Informaticos";
                    break;
            }
            return carrera;
        }

        public static void MetodoBurbuja(string[] texto, int[] cantidad,int k)
        {
            string supuesto;
            int temporal;
            for (int i = 0; i !=k; i++)
            {
                for (int j = 0; j != (k); j++)
                {
                    if (cantidad[j] < cantidad[j + 1])
                    {
                        temporal = cantidad[j];
                        supuesto = texto[j];
                        cantidad[j] = cantidad[j + 1];
                        texto[j] = texto[j + 1];
                        cantidad[j + 1] = temporal;
                        texto[j + 1] = supuesto;
                    }
                }
            }

            for (int j = 0; j != k; j++)
            {
                Console.WriteLine("Nombre del estudiante:{0}\nCarerra: {1}\n", texto[j], Carreras(cantidad[j]));
            }
            Console.ReadKey();
        }


    }
}
