using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAppMonografico
   
{
    public struct Persona{public string nombrePersona; public int anioNacimiento; public int fechaPersona;}

    class Program
    {
       
        static void Main(string[] args)
        {
            //Crea una app de cons que pida datos de una persona (nombre y año nac) hasta que el usuario diga que no desea
            //continuar. Por cada persona debe calcular y presentar su edad.
            int i = 0;
            string a;
            string respUser = "y"; 
            Persona[] datosPersona = new Persona[100];
            
             Console.WriteLine("      GRUPO 12 {0}" +
                    "Monografico #44 {0}" +
                    "Jordy Mario Natera Jimenez {0}" +
                    "Neolfi Catalina Roman Ramirez {0}" +
                    "Maicols Zorrilla Natera {0}", Environment.NewLine);

            do
            {
                i = i+1;
                Console.WriteLine("{0}INSERTE LOS DATOS DE LA PERSONA " + i + "{0}", Environment.NewLine);
                Console.WriteLine("Nombre: ");
                datosPersona[i].nombrePersona = Console.ReadLine();
                Console.WriteLine("Fecha de Nacimiento de " + datosPersona[i].nombrePersona);
                datosPersona[i].anioNacimiento = int.Parse(Console.ReadLine());
                datosPersona[i].fechaPersona = 2020 - datosPersona[i].anioNacimiento;
                Console.WriteLine("Desea continuar? (Y/N)");
               respUser = Console.ReadLine();

            }
            while (respUser == "y" || respUser == "Y");

            //MOSTRANDO DATOS 
            Console.WriteLine("{0}DATOS DE LAS PERSONAS: {0}", Environment.NewLine);
            for (int k = 1; k <= i; k++)
            {
                Console.WriteLine("Persona " + k + " de " + i + "{0}Nombre: " + datosPersona[k].nombrePersona
                    + "{0}Año de Nacimiento: " + datosPersona[k].anioNacimiento
                    + "{0}Edad: " + datosPersona[k].fechaPersona + "{0}", Environment.NewLine);

            }
    
            Console.WriteLine("Presione cualquier tecla para continuar...");
            a = Console.ReadLine();
        }
        
    }  
}
