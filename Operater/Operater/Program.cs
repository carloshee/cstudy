using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operater
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "3.14";
            float dat = float.Parse(num);//1
            double dat2 = Convert.ToDouble(num);
            Console.WriteLine(dat2);
            Console.WriteLine((float)dat2);
            int a = 33;
            double rest = Convert.ToDouble(a);

            Console.WriteLine(rest);
        }
    }
}


//오칙연산 (+,-,*,/,%)
/*
int num = 32767;
int val = num;

Console.WriteLine(num % 10);
Console.WriteLine((num % 100) / 10);
Console.WriteLine((num % 1000) / 100);
Console.WriteLine((num % 10000) / 1000);
Console.WriteLine((num % 100000) / 10000);

int result = val % 10;
Console.WriteLine(result);

val = val / 10;  // 3276
result = val % 10;
Console.WriteLine(result);

val = val / 10;  // 327
result = val % 10;
Console.WriteLine(result);

val = val / 10;  // 32
result = val % 10;
Console.WriteLine(result);

val = val / 10;  // 3
result = val % 10;
Console.WriteLine(result);

//대입
int n = 333;



//증감
int hp = 50;
hp++;
Console.WriteLine(hp);
++hp;
Console.WriteLine(hp);
hp--;
Console.WriteLine(hp);
--hp;
Console.WriteLine(hp);

// hp += 10;
// hp /= 10; 0으로 나누어지지 않도록
//비교  = > 결고는 0, 1이다  = > true , false
int age = 13;
//(age>10)  //(age>20) > , < , >= , <=, ==  
//if(1) if(0)

//논리 and or not
// &&(논리곱)    ||(논리합) !(논리부정) =>값(참 거짓의 관계) 논리를 체크
// &             |   => 메모리(비트) 논리를 체크
// 교집합        합집합     여집합
// 공통(그리고)  또는       아니다
//공통으로 만족할때만       현재부정
//ex)
//(a>10) && (a<50)   a = 32,  a = 9
//a=3;
// ((a == 5)  || (a=7))   할당 => 할당식은 참으로 간주
//논리연산 공부 과제<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<        진법변환         16진수를 10진수로,  2진수를 10진수로,  10진수를 2진수로,  10진수를 15진수로

        int a = 3, b = 4;
        bool x, y;
        x = (a < 0); //false
        y = (b > 0); //true
        Console.WriteLine((a == 3) && (b == 3)); //a만 참이다.
        Console.WriteLine(x || y); //y가 참이다

        Console.WriteLine(2 * 8 - 6 / 2);
        Console.WriteLine(2 * (8 - 6) / 2);
        Console.WriteLine(1 - 2 + 3);
        Console.WriteLine(1 - (2 + 3));

        // 형변환 cast 연산자
        // => 변수 앞에 ()를 넣고 자료형을 넣으면 강제로 형변환이 일어남.
        Console.WriteLine((float)(3 / 2));
        Console.WriteLine(3 / (float)2);
        Console.WriteLine((float)3 / (float)2);
        Console.WriteLine((float)3 / 2);


//삼항   
*/


/*
        //삼항연산자
        //조건식의 값에 따라.. 계산식을 선택함
        //비슷한 문법적인 구조 if - else
        //차이점 : 각 조건별 로직라인 1줄짜리로 제약을 준다.
        //형식
        // 값 ? 로직1 : 로직2 :
        // 0, 1 값 => 값을 비교해서 참(1)일때는 로직1 수행
        //거짓(0) 로직2를 수행
        //(조건식) ? 세팅1: 세팅2:

        string right = "정답";
        string wrong = "오답";
        bool value;

        value = true;
        string answer = value ? right : wrong;
        Console.WriteLine("값은=> " + answer);

        value = false;
        answer = value ? right : wrong;
        Console.WriteLine("값은=> " + answer);

        string answer2;
        value = true;
        answer2 = (value) ? "aaa" : "bbbb";
        */
