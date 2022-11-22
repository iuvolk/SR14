using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Собака");
            dog.ShowInfo();
            Cat cat = new Cat("Кошка", "Мяяу");
            cat.ShowInfo();
            Console.ReadKey();

        }
    }
}
