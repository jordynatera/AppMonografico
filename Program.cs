﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAppMonografico
   
{
    public struct Persona
        {
            public string nombrePersona;
            public string anioNacimiento;
        }
    class Program
    {
       
        static void Main(string[] args)
        { 

            //Crea una app de cons que pida datos de una persona (nombre y año nac) hasta que el usuario diga que no desea
            //continuar. Por cada persona debe calcular y presentar su edad.
            string respUser = "y";  
            do
            {          
                Console.WriteLine("      GRUPO 12 {0}" +
                    "Monografico #44 {0}" +
                    "Jordy Mario Natera Jimenez {0}" +
                    "Neolfi Catalina Roman Ramirez {0}" +
                    "Maicols Zorrilla Natera {0}", Environment.NewLine);
                int i = 0;

                Persona[] datosPersona = new Persona[100];    
                
                Console.WriteLine("Inserte los datos de la persona " + i + "{0}", Environment.NewLine);
                Console.WriteLine("Nombre: ");
                datosPersona[i].nombrePersona = Console.ReadLine();

                Console.WriteLine("Fecha de Nacimiento de " + datosPersona[i].nombrePersona + ": {0}", Environment.NewLine);
                datosPersona[i].anioNacimiento = Console.ReadLine();

                //Prueba
                Console.WriteLine("{0}PRUEBA DE SALIDA: {0}{0}PERSONA "+i+"{0}Nombre "+ i + ": "+ datosPersona[i].nombrePersona + "{0}", Environment.NewLine);
                Console.WriteLine("Fecha de Nacimiento de "+ datosPersona[i].nombrePersona + ": " + datosPersona[i].anioNacimiento+ "{0}", Environment.NewLine);
                
                Console.WriteLine("Desea continuar? (Y/N){0}", Environment.NewLine);
                respUser = Console.ReadLine();
                i = i++;
            }
            while (respUser == "y" || respUser == "Y");
        }
        
    }  
}