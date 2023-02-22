using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  namespace Laboratorio1
  {
        class Program
        {
            static void Main(string[] args)
            {
                string nombre, departamento, municipio;
                int edad;
                string[] municipiosDepa;


                string[,] datos = new string[8, 4];

                for (int mun = 0; mun < 3; mun++)
                {
                    Console.WriteLine("Porfavor rellenar los siguientes datos de la persona " + (mun + 1));

                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();

                    Console.Write("Edad: ");
                    edad = int.Parse(Console.ReadLine());
                

                    Console.Write("Departamento: ");
                    departamento = Console.ReadLine();

                    Console.Write("Municipio: ");
                    municipio = Console.ReadLine();


                    municipiosDepa = EncontrarMuniDepa(departamento);

                    while (!Array.Exists(municipiosDepa, element => element == municipio))
                    {
                        Console.WriteLine(" ERROR! " +
                            " El nombre del departamento/municipio está mal escrito o el municipio no se ecuentra en el departamento seleccionado. ");

                        Console.Write("Municipio: ");
                        municipio = Console.ReadLine();
                    }


                    datos[mun, 0] = nombre;  datos[mun, 1] = edad.ToString();datos[mun, 2] = departamento; datos[mun, 3] = municipio;
                }


                Console.WriteLine("Edades de las personas registradas:");
                for (int mun = 0; mun < 3; mun++)
                {
                    Console.WriteLine(datos[mun, 1]);
                }

                Console.ReadKey();


            }


            static string[] EncontrarMuniDepa(string departamento)
            {
                string[] Municipios;

                switch (departamento)
                {
                    case "San Salvador":
                        Municipios = new string[] { "Apopa", "Antiguo Cuscatlán",  "Cuscatancingo", "Santa Tecla ", "Ayutuxtepeque","Soyapango", "Ciudad Delgado","Ilopango" };
                        break;
                    case "Chalatenango":
                        Municipios = new string[] { "El Paraiso", "Dulce Nombre de Maria", "Nueva Concepcion", "Citalá", "San Rafael","Tejutla", "El Carrizal","Chalatenango" };
                        break;
                    case "Santa Ana":
                        Municipios = new string[] { "Metapán", "Candelaria de la Frontera", "Chalchuapa", "Coatepeque", "Masahuat", "Santa Ana", "Santa Rosa Guachipilín", "Texistepeque" };
                        break;
                    case "San Miguel":
                        Municipios = new string[] { "Chapeltique", "Chinameca", "San Antonio", "Carolina", "Cuidad Barrios", "Lolotique", "San Jorge", "Sesori" };
                        break;
                    case "San Vicente":
                        Municipios = new string[] { "Apastepeque", "Guadalupe", "San Ildefonso", "San Lorenzo", "San Sebastián", "San Vicente", "Tecoluca", "Tepetitán" };
                        break;
                    case "Sonsonate":
                        Municipios = new string[] { "Acajutla", "Armenia", "Caluco", "Cuisnahuat", "Izalco", "Juayúa", "Nahuizalco", "Sonzacate" };
                        break;

                default:
                        Municipios = new string[] { };
                        break;
                }

                return Municipios;
            }
        }
  }


