// See https://aka.ms/new-console-template for more information
using System;
using EspacioCalculadora;
Console.WriteLine("Hello, World!");

Calculadora calc=new Calculadora();
int opcion;
do
{
    System.Console.WriteLine("-----CALCULADORA------");
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Multiplicar");
    Console.WriteLine("4.Dividir");
    Console.WriteLine("5.Limpiar");
    Console.WriteLine("6.Salir");

     System.Console.WriteLine("Seleccione la operacion a realizar:");
    
    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        switch (opcion)
        {
            case 1: //suma
                Console.WriteLine("Ingrese el numero a sumar: ");
                if (double.TryParse(Console.ReadLine(), out double numSuma))
                {
                    calc.Sumar(numSuma);
                }else
                {
                    Console.WriteLine("Error...");
                }    
            break;
            case 2://resta
                Console.WriteLine("INgrese el numero a restar: ");
                 if (double.TryParse(Console.ReadLine(), out double numResta))
                {
                    calc.Sumar(numResta);
                }else
                {
                    Console.WriteLine("Error...");
                }  
            break;
             case 3://multiplicacion
                 Console.WriteLine("INgrese el numero a multiplicar: ");
                 if (double.TryParse(Console.ReadLine(), out double numMulti))
                {
                    calc.Sumar(numMulti);
                }else
                {
                    Console.WriteLine("Error...");
                }  
            break;
             case 4://division
                     Console.WriteLine("INgrese el numero a restar: ");
                 if (double.TryParse(Console.ReadLine(), out double numDiv))
                {
                    calc.Sumar(numDiv);
                }else
                {
                    Console.WriteLine("Error...");
                }  
            break;
             case 5://limpiar
                    calc.Limpiar();
            break;
            default:
                   
            break;
        }

       
    }else
    {
        Console.WriteLine("Error...ingrese nuevamente un numero del 1 al 6");
    }
    
} while (opcion!= 6);