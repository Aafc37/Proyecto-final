using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.InteropServices;

namespace PROYECTO_FINAL
{

    class Program
    {



        static void Main(string[] args)
        {
            string opcion;
            int[] anio;
            int[] cale;
            int[] cale2;
            int[] op2;
            int[] habi;
            int[] habise;
            int[] cale3;
            int[] ilumi;
            int[] ilumi2;
            int[] temperatura;
            int[] apagar;
            int[] max;
            int[] min;
            string[] nombre;


            Console.WriteLine(" Creadores : Angel Fuentes 1162522 y Fryda Orellana 1024822");
            Console.WriteLine(" ");
        Menu:

            Console.WriteLine("Sistema de automatización del hogar ");
            Console.WriteLine("Presione 1: ------>Ventilación ");
            Console.WriteLine("Presione 2: ------> Calefacción:");
            Console.WriteLine("Presione 3: ------>  Iluminación");
            Console.WriteLine("Presione 4: ------> Panel de control:");
            Console.WriteLine("Presione 5: ------> Salir");
            opcion = Console.ReadLine();



            anio = new int[5];
            cale = new int[5];
            cale2 = new int[5];
            cale3 = new int[5];
            op2 = new int[5];
            habi = new int[5];
            habise = new int[5];
            ilumi = new int[5];
            temperatura = new int[5];
            max = new int[5];
            min = new int[5];
            ilumi2 = new int[5];
            apagar = new int[5];

            Console.WriteLine("Ingrese su nombre: ");
            string Nombre = Console.ReadLine();
            Console.ReadKey();
            /* COMENTARIOS */
            Console.Write("Eres:  " + Nombre);
            Console.ReadKey();

            switch (opcion)
            {
                case "1":


                    for (int f = 0; f < 1; f++)
                    {


                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el grado de humedad ");
                        string fe;

                        fe = Console.ReadLine();
                        anio[f] = int.Parse(fe);


                        if (anio[f] >= 70)
                        {


                            Console.WriteLine("La ventilación comenzará a trabajar");


                        }
                        else if (anio[f] <= 70)
                        {


                            Console.WriteLine("La ventilación no comenzará a trabajar"); Console.WriteLine(""); goto Menu;

                        }


                    }



                    Console.WriteLine("");

                venti:  

                    Console.WriteLine(" opcion 1: 7:00 am - 10:00 am");
                    Console.WriteLine(" ");
                    Console.WriteLine(" opcion 2: 10:00 am - 12:00 am");
                    Console.WriteLine(" ");
                    Console.WriteLine(" opcion 3: 5:00 pm - 10:00 pm");



               

                    for (int f = 0; f < 1; f++)
                    {


                        Console.WriteLine("");
                        Console.WriteLine("Ingrese la hora que desea  ");
                        string fe;

                        fe = Console.ReadLine();
                        anio[f] = int.Parse(fe);


                    }
                    Console.WriteLine("");



                    for (int f = 0; f < 1; f++)
                    {

                        if (anio[f] == 1)
                        {


                            Console.WriteLine("la hora selecciona es de 7:00 am - 10:00 am");


                            Console.WriteLine(""); goto Menu;
                        }

                        else if (anio[f] == 2)
                        {

                            Console.WriteLine("la hora selecciona es de 10:00 am - 12:00 am");
                            Console.WriteLine(""); goto Menu;
                        }
                        else if (anio[f] == 3)
                        {
                            Console.WriteLine("la hora selecciona es de 5:00 pm - 10:00 pm");
                            Console.WriteLine(""); goto Menu;

                        }
                        else if (anio[f] >= 4)
                        {
                            Console.WriteLine("Error, no se ha ingresado una funcion disponible");

                            goto venti;
                        }

                    }

                    break;



                case "2":



                    Console.WriteLine("Los radiadores se encuentran apagados, desea encenderlos? ");
                    Console.WriteLine(" ");


                    Console.WriteLine(" opcion 1: si");
                    Console.WriteLine(" ");
                    Console.WriteLine(" opcion 2: no");
                    Console.WriteLine(" ");


                    for (int f = 0; f < 1; f++)
                    {


                        string fe;

                        fe = Console.ReadLine();
                        anio[f] = int.Parse(fe);


                    }
                    Console.WriteLine("");

                    for (int f = 0; f < 1; f++)
                    {

                        if (anio[f] == 1)
                        {


                            Console.WriteLine("Los radiadores comenzaran a trabajar ");
                            Console.WriteLine("");

                        }
                        else if (anio[f] == 2)
                        {
                            Console.WriteLine("Los radiadores se mantendran apagados ");
                            Console.WriteLine(""); goto Menu;


                        }


                        Console.WriteLine("En que habitacion desea encender los riadadores ");
                        Console.WriteLine("");


                        Console.WriteLine(" habitacion 1 ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" habitacion 2");
                        Console.WriteLine(" ");
                        Console.WriteLine(" habitacion 3");
                        Console.WriteLine(" ");
                        Console.WriteLine(" habitacion 4");

                        string fe;

                        fe = Console.ReadLine();
                        cale[f] = int.Parse(fe);



                        Console.WriteLine("");

                        if (cale[f] >= 1 && cale[f] <= 4)
                        {
                            Console.WriteLine(" Se ha seleccionado la habitacion numero " + cale[f]);
                            Console.WriteLine("");
                        }
                        else if (cale[f] > 4)
                        {
                            Console.WriteLine("Eror"); break;
                        }


                        Console.WriteLine("");
                        Console.WriteLine(" Ingrese la temperatura para la habitacion en grados No." + cale[f]);


                        string ha;

                        ha = Console.ReadLine();
                        habi[f] = int.Parse(ha);

                        Console.WriteLine("");


                        if (habi[f] < 18)
                        {
                            Console.WriteLine("Erro");
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese una temperatura que se encuentre en el rango correcto");

                            string ma;

                            ma = Console.ReadLine();
                            habi[f] = int.Parse(ma);
                            Console.WriteLine("");

                            if (habi[f] < 18)
                            {
                                Console.WriteLine("Erro"); break;
                            }
                            else if (habi[f] >= 18 && habi[f] <= 22)
                            {
                                Console.WriteLine("La temperatura de la habitacion No." + cale[f] + " es de " + habi[f]);
                            }



                        }


                        else if (habi[f] > 22)
                        {
                            Console.WriteLine("Erro");

                            Console.WriteLine("");
                            Console.WriteLine("Ingrese una temperatura que se encuentre en el rango correcto");

                            string ra;

                            ra = Console.ReadLine();
                            habi[f] = int.Parse(ra);
                            Console.WriteLine("");

                            if (habi[f] > 22)
                            {
                                Console.WriteLine("Erro"); break;
                            }
                            else if (habi[f] >= 18 && habi[f] <= 22)
                            {
                                Console.WriteLine("La temperatura de la habitacion No." + cale[f] + " es de " + habi[f]);
                            }

                        }



                        else if (habi[f] >= 18 && habi[f] <= 22)
                        {
                            Console.WriteLine("La temperatura de la habitacion No." + cale[f] + " es de " + habi[f]);
                        }

                        for (int n = 0; n < 3; n++)


                        {
                            Console.WriteLine("");
                            Console.WriteLine("Desea agregar otra habitacion?");
                            Console.WriteLine("");
                            Console.WriteLine(" opcion 1: si");
                            Console.WriteLine(" ");
                            Console.WriteLine(" opcion 2: no");
                            Console.WriteLine(" ");



                            string re;

                            re = Console.ReadLine();
                            op2[n] = int.Parse(re);
                            Console.WriteLine("");



                            if (op2[n] == 1)
                            {
                                Console.WriteLine("Seleccione la habitacion que desea agregar ");



                                Console.WriteLine(" habitacion 1 ");
                                Console.WriteLine(" ");
                                Console.WriteLine(" habitacion 2");
                                Console.WriteLine(" ");
                                Console.WriteLine(" habitacion 3");
                                Console.WriteLine(" ");
                                Console.WriteLine(" habitacion 4");

                                string te;

                                te = Console.ReadLine();
                                cale3[f] = int.Parse(te);

                                Console.WriteLine("");

                                if (cale3[n] >= 0 && cale3[f] <= 4)
                                {
                                    Console.WriteLine(" Se agrego la habitacion No." + cale3[f]);
                                    Console.WriteLine("");

                                    Console.WriteLine(" Se estaran modificando la habitacion");

                                    Console.WriteLine("");
                                    Console.WriteLine(" Ingrese la temperatura para la habitacion en grados No." + cale3[f]);


                                    string la;

                                    la = Console.ReadLine();
                                    habise[f] = int.Parse(la);

                                    Console.WriteLine("");




                                    if (habise[f] < 18)
                                    {


                                        Console.WriteLine("Erro");
                                        Console.WriteLine("");
                                        Console.WriteLine("Ingrese una temperatura que se encuentre en el rango correcto");

                                        string ma;

                                        ma = Console.ReadLine();
                                        habise[f] = int.Parse(ma);
                                        Console.WriteLine("");

                                        if (habise[f] < 18)
                                        {
                                            Console.WriteLine("Erro"); goto Menu;


                                        }
                                        else if (habise[f] >= 18 && habise[f] <= 22)
                                        {
                                            Console.WriteLine("La temperatura de la habitacion No." + cale3[f] + " es de " + habise[f]);

                                        }



                                    }


                                    else if (habise[f] > 22)
                                    {
                                        Console.WriteLine("Erro");

                                        Console.WriteLine("");
                                        Console.WriteLine("Ingrese una temperatura que se encuentre en el rango correcto");

                                        string ra;

                                        ra = Console.ReadLine();
                                        habise[f] = int.Parse(ra);
                                        Console.WriteLine("");



                                        if (habise[f] > 22)
                                        {
                                            Console.WriteLine("Erro"); goto Menu;
                                        }
                                        else if (habi[f] >= 18 && habise[f] <= 22)
                                        {
                                            Console.WriteLine("La temperatura de la habitacion No." + cale3[f] + " es de " + habise[f]);
                                        }

                                    }



                                    else if (habise[f] >= 18 && habise[f] <= 22)
                                    {
                                        Console.WriteLine("La temperatura de la habitacion No." + cale3[f] + " es de " + habise[f]);
                                    }



                                }
                                else if (cale[n] > 4)
                                {
                                    Console.WriteLine("Error, no se ingreso ninguna de las habitaciones disponibles");


                                }
                            }


                            if (op2[n] == 2)
                            {
                                goto Menu;
                            }


                        }


                    }

                    break;



                case "3":

                    Console.WriteLine("bienvenido a la iluminacion");
                    Console.WriteLine("");


                    Console.WriteLine(" habitacion 1 ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" habitacion 2");
                    Console.WriteLine(" ");
                    Console.WriteLine(" habitacion 3");
                    Console.WriteLine(" ");
                    Console.WriteLine(" habitacion 4");

                    Console.WriteLine(" ");
                cc1:

                    for (int f = 0; f < 1; f++)
                    {
                       

                        Console.WriteLine("Ingrese le numero de habitacion que se encuentra ocupada");
                        Console.WriteLine(" ");
                        string fe;

                        fe = Console.ReadLine();
                        ilumi[f] = int.Parse(fe);

                        Console.WriteLine("La iluminacion esta encendida en la habitacion " + ilumi[f]);


                        Console.WriteLine(" ");

                    }






                    for (int f = 0; f < 1; f++)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Desea agregar otra habitacion? ");

                        Console.WriteLine("Opcion 1: si");
                        Console.WriteLine(" ");
                        Console.WriteLine("Opcion 2: no");
                        Console.WriteLine(" ");
                        string fe;
                        fe = Console.ReadLine();
                        ilumi2[f] = int.Parse(fe);
                        Console.WriteLine(" ");


                        if (ilumi2[f] == 1)
                        {
                            Console.WriteLine(" ");
                            goto cc1;

                        }
                        else if (ilumi2[f] == 2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine(" La iluminacion se mantendra encendida en las habitaciones seleccionadas anteriormente");
                            Console.WriteLine(" ");
                            Console.WriteLine(" Desea apagar la iluminacion");
                            Console.WriteLine(" ");
                            Console.WriteLine("Opcion 1: si");
                            Console.WriteLine(" ");
                            Console.WriteLine("Opcion 2: no");

                            string se;
                            se = Console.ReadLine();
                            apagar[f] = int.Parse(se);
                            Console.WriteLine(" ");


                        apagar:

                            if (apagar[f] == 2)
                            {
                                goto Menu;
                            }

                                if (apagar[f] == 1)
                            {
                                Console.WriteLine("Ingrese le numero de habitacion que desea desocupar");
                                Console.WriteLine(" ");
                                string me;

                                me = Console.ReadLine();
                                ilumi[f] = int.Parse(me);

                                Console.WriteLine("La iluminacion esta apagara en la habitacion " + ilumi[f]);




                                Console.WriteLine(" ");
                                Console.WriteLine("Desea agregar otra habitacion? ");

                                Console.WriteLine("Opcion 1: si");
                                Console.WriteLine(" ");
                                Console.WriteLine("Opcion 2: no");
                                Console.WriteLine(" ");


                                string tte;
                                tte = Console.ReadLine();
                                ilumi2[f] = int.Parse(tte);
                                Console.WriteLine(" ");


                                if (ilumi2[f] == 1)
                                {
                                   
                                    goto apagar;


                                    Console.WriteLine(" ");
                                }
                                else if (ilumi2[f] == 2)
                                {

                                    goto Menu;





                                }
                                else if (ilumi2[f] >= 3)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("No se ingreso ninguna opcion");
                                    Console.WriteLine(" ");
                                    goto Menu;
                                }

                            }
                        }
                    }


                    break;


                case "4":
                    Console.WriteLine("Se encuentra en el panel de control");
                    Console.WriteLine("");


                    Console.WriteLine("Elija una opcion");
                    Console.WriteLine("1. El sistema de ventilación ");
                    Console.WriteLine("2. Temperaturas máximas y mínimas  ");
                    Console.WriteLine("3. Promedio de las temperaturas máximas y mínimas  ");


                    for (int f = 0; f < 1; f++)
                    {
                        Console.WriteLine("Ingrese la opcion que desea ");
                

                      

                        string fe;

                        fe = Console.ReadLine();
                        temperatura[f] = int.Parse(fe);



                        if (temperatura[f] == 2)
                        {
                            Console.WriteLine("Ingrese la temperatura maxima que desea  ");
                            Console.WriteLine(" ");

                            fe = Console.ReadLine();
                            max[f] = int.Parse(fe);


                            Console.WriteLine("La tempertura maxima sera de  " + max[f]);
                            Console.WriteLine(" ");

                            Console.WriteLine("Ingrese la temperatura minima que desea  ");
                            Console.WriteLine(" ");

                            fe = Console.ReadLine();
                            min[f] = int.Parse(fe);

                            Console.WriteLine("La tempertura minima sera de  " + min[f]);

                            goto Menu;
                            Console.WriteLine(" ");
                        }

                        else  if (temperatura[f] == 3) 
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("El promedio de las temperaturas maximas es de 30 ");
                            Console.WriteLine(" ");
                            Console.WriteLine("El promedio de las temperaturas minimas  es de 40 ");

                            goto Menu;
                        } 
                        else if  (temperatura[f] == 1)
                        {
                            goto venti;
                        }
                        


                    }  
                   

                            break;




                case "5":
                    Console.WriteLine("Gracias por ingresar");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("");
                    Console.WriteLine("No seleccionó ninguna de las opciones disponibles ");
                    Console.WriteLine("");
                    goto Menu;

            }


            Console.ReadKey();
        }
    }
}