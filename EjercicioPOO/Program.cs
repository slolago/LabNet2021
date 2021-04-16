using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> transportes = new List<Transporte>
            {
                new Avion ("Avion1", 100),
                new Avion ("Avion2", 230),
                new Avion ("Avion3", 300),
                new Avion ("Avion4", 150),
                new Avion ("Avion5", 80),
                new Auto ("Auto1", 4),
                new Auto ("Auto2", 5),
                new Auto ("Auto3", 3),
                new Auto ("Auto4", 2),
                new Auto ("Auto5", 1)

            };

            foreach (var item in transportes)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
