using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance1
{
    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine("{0}.Base()", this.Name);
        }

        ~Base()
        {
            Console.WriteLine("{0}.~Base()", this.Name);
        }

        public void BaseMethod()
        {
            Console.WriteLine("{0}.BaseMethod()", Name);
        }
    }

    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        {
            Console.WriteLine("{0}.Derived()", this.Name);
        }

        ~Derived()
        {
            Console.WriteLine("{0}.~Derived()", this.Name);
        }

        public void DerivedMethod()
        {
            Console.WriteLine("{0}.DerivedMethod", Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Base("b");
            b.BaseMethod();
            //b.DerivedMethod();
        }
    }
}
