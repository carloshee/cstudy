using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameTest
{
    public class TestA
    {
        public void showdata()
        {
            Console.WriteLine("nametest 영역에 있는 클래스입니다.");
        }
    }
}

// 클래스 이름은 중복 안됨 => namespace
// 1. namespace 이름을 중복하면 ... 어떻게 될까?  =>  합쳐진다.
// 2, namespace 이름이 중복되면 내부 클래스는?    =>  같은 이름의 클래스가 있으면 중복정의 에러
namespace NameTest2 //namespace 중복
{
    class Program
    {
        static void Main(string[] args)
        {
            NameTest.TestA a = new NameTest.TestA();
            a.showdata();

            // namespace의 이름이 중복되면 ... 같은 이름의 namespace끼리 합쳐진다.
            // namespace 는 분활해서 합쳐서 쓸 수 있다.
            NameTest.TestA b = new NameTest.TestA();
            b.showdata();
        }
    }
}
