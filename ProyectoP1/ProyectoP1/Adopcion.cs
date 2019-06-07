using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoP1
{
    public class Adopcion
    {
        public Adopcion(Animal an, Persona pe)
        {
            
            string nombreMascota = an.Nombre;
            string razaMascota = an.Raza;
            string nombrePer = pe.Nombre;
            int edadPer = pe.Edad;
            
            nuevaAdopcion(nombreMascota,  razaMascota, nombrePer, edadPer);
        }

       public void nuevaAdopcion(string nombreMascota, string razaMascota, string nombrePer, int edadPer)
        {

            Console.WriteLine("Proporcionar el nombre del dueño");
            nombrePer = Console.ReadLine();
            Console.WriteLine("Edad del propietario");
            edadPer = Convert.ToInt32( Console.ReadLine());





            Console.WriteLine("Favor de elegir a su mascota");
            Console.WriteLine("1. Perro");
            Console.WriteLine("2. Gato");
            

            string op = Console.ReadLine();

            if (op== "1")
            {
                Console.WriteLine("Dime el nombre de tú mascota");
                nombreMascota = Console.ReadLine();
                Console.WriteLine("Proporcionar la Raza de tú mascota");
                razaMascota = Console.ReadLine();
                
            }
            if (op == "2")
            {
                Console.WriteLine("Dime el nombre de tú mascota");
                nombreMascota = Console.ReadLine();
                Console.WriteLine("Proporcionar la Raza de tú mascota");
                razaMascota = Console.ReadLine();
            }

            Console.WriteLine("Felicidades " +nombrePer + " has adoptado a " +nombreMascota +" de tipo " +razaMascota);
      
        }

    }

  
}
