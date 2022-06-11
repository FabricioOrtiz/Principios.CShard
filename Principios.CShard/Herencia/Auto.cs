using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.CShard.Herencia
{
    public abstract class Auto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Precio { get; set; }

        public void Avanzar() 
        {
            Console.WriteLine($"El auto {Name} , esta avanzo");
        }

        public void PrintPrecio()
        {
            Console.WriteLine($"El auto {Name} , tiene el precio de ${Precio}");
        }
    }
}
