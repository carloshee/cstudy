using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// 일반화(Generic) 클래스 - 템플릿(c++) 클래스
// java , c#
// 클래스선언시 필요한 내부 맴버 자료형이 일반화 자료형으로 만들어진 클래스
// 자료형의 구체적인 형태는 객체 생성자에 지정함
// 형식
/*
class 클래스명<T>
{
    T멤버 ... 생성
}
  
 */
class A     //A()
{
    public int m_x;
    public int m_y;
    public float m_z;
}

// <단어>       // 무슨자료형이든 올 수 있다. <>내부의 단어는 중요하지 않음
                // <   >
class A <G, S>  // 일반화클래스 = 클래스 + 일반화자료형 
{               // 일반자료형은 1개 이상이 올 수 있다. 구분을 위해서 .를 사용
                // A<G, S>();

    public G m_x;
    public G m_y;
    //public float m_z; // 1) 보통 멤버변수가 올수도 있다.
    public S m_z;
    public S m_t;
}

/*
// 사용은 ... 
// 자료형
클래스형<일반화키워드> 변수 = new 생성자<일반화키워드>();
*/

class connector<T>
{
    public string connect(T a, T b)
    {
        return a.ToString() + b.ToString();
    }
}

namespace CopyingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            A<int, float> a = new A<int, float>();
            a.m_x = 1;
            a.m_t = 3.14f;

            connector<int> c = new connector<int>();
            Console.WriteLine(c.connect(123, 486));
        }
    }
}


/*
static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }

        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);

            foreach (int elemnet in target)
                Console.WriteLine(elemnet);

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };
            string[] target2 = new string[source2.Length];

            CopyArray<string>(source2, target2);

            foreach (string elment in target2)
                Console.WriteLine(elment);
        }  
 */
