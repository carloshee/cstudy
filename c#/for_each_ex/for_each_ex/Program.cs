using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace for_each_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //for문을 이용한 객체데이터 접근 및 정보취득
            //컬렉션 객체 1개이상의 데이터를 가진 (복수) 자료형, 클래스
            //배열 배열 index, 리스트 현재위치 데이터1개
            //foreach(데이터타입 변수명 in 배열이나 컬렉션객체)
            //=>해당객체가 가진 모든데이터를 ()안에 선언된 변수에 차례로 넣어줌.
            int[] num = { 1, 2, 3, 4, 5 };
            foreach(int readdata in num) //하나씩 넣어주면서 반복 > 값이 없을때 까지
            {
                Console.WriteLine(readdata);
            }
            string[] itemlist = new string[] { "집행검", "돌도끼", "레이저총" };
            string[] tmp = new string[3];
            int count = 0;

            foreach (string name in itemlist)
            {
                Console.WriteLine(name);
                tmp[count] = name;
                count++;
            }
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(tmp[j]);
            }
        }
    }
}
