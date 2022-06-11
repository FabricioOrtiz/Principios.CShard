using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios.CShard.Poliformismo
{
    public class Index
    {
        /*
         El polimorfismo se refiere a la posibilidad de definir múltiples clases con funcionalidad diferente, pero con métodos o propiedades denominados de forma idéntica.
         */
    }

    public class Alumno : PersonaBase
    {
        public override void Saludar()
        {
            Console.WriteLine("Holis");
        }
    }

    public abstract class PersonaBase
    {
        public string Name { get; }
        public string Description { get; }
        public abstract void Saludar();
    }
}
