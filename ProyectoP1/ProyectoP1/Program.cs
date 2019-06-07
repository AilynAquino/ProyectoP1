using System;

namespace ProyectoP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************ADOPCIÓN EXPRESS********************************");
            Animal an = new Animal();
            Persona pe = new Persona();
            Adopcion p = new Adopcion(an, pe);
            Animal A = new Animal();
        }
    }
}
