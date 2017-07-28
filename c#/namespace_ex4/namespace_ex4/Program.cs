using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Fishing;
using F = Fishing; // 네임스페이스의 별명을 등록
        //해당 namespace의 별명을 지어줌

namespace Fishing
{
    class Fish
    {
        int num; // 개수
        string name;
        public Fish(string m, int n)
        {
            name = m;
            num = n;
        }
        public void print()
        {
            Console.WriteLine(" 몇마리 " + num + " 낚았음");
        }
     }
}

namespace namespace_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fishing.Fish a = new Fishing.Fish("정어리", 2);
            F.Fish b = new F.Fish("상어", 10);
            Fish c = new Fish("방어", 2);
            a.print();
            b.print();
            c.print();
        }
    }
}
