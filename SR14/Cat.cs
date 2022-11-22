using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR14
{
    class Cat : Animal
    {
        string name;
        string say;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Cat(string name, string say)
            : base(name)
        {
            this.say = say;
        }

        public override void Say()
        {
            Console.WriteLine(say);
        }
    }

}

