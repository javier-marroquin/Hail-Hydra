using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia9_Ejercicio_4
{
    class Program
    {   /*Dados los carné de las personas que llevan IAI-115, se pide que 
        imprima la cantidad de personas que cursan por año de ingreso. 
        Suponga que los carnés están entre el año 2000 y el año actual.  
        Además se pide que imprima el porcentaje que son de nuevo ingreso.*/
        static void Main(string[] args)
        {

            string[] carnet = new string[100];
            string b;
            int cont = 0,correlativo,acumulador=0,a=1;
           

            do
            {
                Console.WriteLine("Introdusca el carnet del estudiante {0}", cont + 1);
                carnet[cont] = ValidarCarnet();
              
                cont++;
               Console.Clear();
                Console.WriteLine("\tHa terminado de registrar datos?\nPara continuar precione ENTER, Para terminar precione 0 y en seguida ENTER ");
                b = Console.ReadLine();
            } while (b != "0");
 
            for(int i=0; i !=17;i++)
            {
                a = 1;
                acumulador = 0;
                for (int j=0;j!=cont;j++)
                {
                    correlativo = Convert.ToInt16(carnet[j].Substring(2, 2));
                    if (correlativo==i)
                    {
                        acumulador++;
                        a = 0;
                    }
                }
                if(a==0)
                Console.WriteLine("Los Estudiantes del año {0} son {1}", i + 2000, acumulador);
            }


            Console.ReadKey();

        }

        public static string ValidarCarnet()
        {
            string carnet;
            char inicial1,inicial2,corrl1,corrl2;
            do
            {
                carnet = Console.ReadLine().ToUpper();

                inicial1 = Convert.ToChar(carnet.Substring(0, 1));
                inicial2 = Convert.ToChar(carnet.Substring(1, 1));
                corrl1 = Convert.ToChar(carnet.Substring(2, 1));
                corrl2 = Convert.ToChar(carnet.Substring(3, 1));
                if (!(carnet.Length == 7 && inicial1 >= 'A' && inicial2 >= 'A' && corrl1 >= '0' && corrl2 >= '0')) ;
                {
                    Console.WriteLine("Error de datos ingresados, debe ser un carnet valido");
                    Console.WriteLine("Introdusca el carnet del estudiante");
                }

            } while (!(carnet.Length == 7 && inicial1 >= 'A' && inicial2 >= 'A' && corrl1 >= '0' && corrl2 >= '0'));
            return carnet;
        }
    }
}
