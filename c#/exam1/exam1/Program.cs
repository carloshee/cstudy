using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exam1
{
    class Program
    {
        enum Animal : Int32 { mouse, cat, bird, dog = 100, pig = 200, lion }
        static void Main()
        {
            Animal a;
            a = Animal.dog;
            Console.WriteLine(Animal.bird);
            Console.WriteLine(Animal.pig);
            Console.WriteLine((int)Animal.pig);
            Console.WriteLine((int)a + "animal" + a);
        }
    }
}

/*int num = 82;

            if (num >= 90)                  //조건 -> 값,  값 -> 조건
                Console.WriteLine("A");
            else if (num >= 80)
                Console.WriteLine("B");
            else
                Console.WriteLine("C");


            switch (num / 10)  // 값이 온다.. -> 계산 .. 값이 오는것.
            {
                case 10:
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                default:
                    Console.WriteLine("C");
                    break;
            }

     // 상수
            // 변수 선언과 비슷하지만 앞에 const 키워드를 붙인다.
            // 생성과 동시에 초기화
            // 생성후 초기화 안됨.
            // 생성후 값의 변경 안됨
            // const int A_Score = 9;
            // 열거 ...
            // 멤버변수별로 자동으로 값이 세팅되는 자료형
            // 형식
            //1) 자료형의 선언
            // enum  자료형이름 { 파라미터(키워드) }; // 해당키워드에 값이 자동으로 세팅이 된다.
            //                                           0부터 세팅이 됨
            //2) 변수선언
            // 열거자료형 변수
            // 변수에 값을 세팅
            // 변수 = 열거형 파라미터, 파라미터가 가르키고 있는 숫자 값이 변수에 들어감
 */


/*enum GameState { Load = 1, Intro, Game, Option = 7, Exit }
       static void Main(string[] args)
       {
           GameState state;
           state = GameState.Load;
           Console.WriteLine(state);
           Console.WriteLine((int)GameState.Load);
           Console.WriteLine((int)GameState.Exit);

           switch (state)
           {
               case GameState.Load:
                   Console.WriteLine("Load");
                   break;
               case GameState.Game:
                   Console.WriteLine("Game");
                   break;
               case GameState.Option:
                   Console.WriteLine("Exit");
                   break;
               case GameState.Intro:
                   break;

           }
       }
 */
