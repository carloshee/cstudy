using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("요일 입력 : ");
            string day = Console.ReadLine();
            
            switch (day)
            {
                case "월":
                    Console.WriteLine("monday");
                    break;
                case "화":
                    Console.WriteLine("Tuesday");
                    break;
                case "수":
                    Console.WriteLine("Wednesday");
                    break;
                case "목":
                    Console.WriteLine("Thursday");
                    break;
                case "금":
                    Console.WriteLine("Friday");
                    break;
                case "토":
                    Console.WriteLine("Saturday");
                    break;
                case "일":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("잘못 입력했습니다.");
                    break;
            }


        }
    }
}


// 요일을 입력받으면 해당 요일을 영어로 출력하는 프로그램을 만드시오
// 단 요일외에 글자나 숫자를 입력받으면 "잘못 입력했습니다."를 출력하시오.
// console.inputline 1)if-else 2)switch-case 
/*
 string inputsum = Console.ReadLine();
            Console.WriteLine("입력값은" + inputsum);
            //숫자로 출력하기
            Console.WriteLine("입력값은" + int.Parse(inputsum));
            Console.WriteLine("입력값은" + Convert.ToInt32(inputsum));

    */