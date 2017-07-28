using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class parent
{
    public virtual void name()
    {
        Console.WriteLine("부모");
    }
}

class child : parent
{
    public override void name() // 자식: 재정의의미  파생클래스 입장: virtual 의미
    {
        Console.WriteLine("자식");
    }
}

class grandson : child
{
    public override void name()
    {
        Console.WriteLine("손자");
    }
}

class Program
{
    static void Main(string[] args)
    {
        parent obj1 = new parent();
        child obj2 = new child();
        grandson obj3 = new grandson();
        obj1.name();
        obj2.name();
        obj3.name();
    }
}
