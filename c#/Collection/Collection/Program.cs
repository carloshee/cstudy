using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
// 같은 자료형의 집합 1개이상의 => collection
// Arraylist = list 객체
// HashTable => Dictionarry (key-value 객체)
// stack, Queue;
// using system coolection
namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList(); // 생성 초기화
                                           // 데이터 없는 

            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while (que.Count > 0)
                Console.WriteLine(que.Dequeue());
        }
    }
}
