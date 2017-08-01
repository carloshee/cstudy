using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// 인덱서
// 객체내의 배열을 접근(access) 해서 클래스를 배열처럼 취급하는 문법
// 기본 문법베이스는 속성(property, get/set ) 과 유사
// 특징:
/*
 * 배열을 접근하듯이 []기호를 사용함
 * this 키워드를 사용한다
 * get/set 접근자로 표현
 * 멤버변수처럼 보이지만.. 내부적으로 메서드로.. 동작
 */
/*
 * 형식
 * 1. 멤버자료형으로 배열이 필요...
 * 2. 접근권한 리턴타입 this [index]
 * {
 *     get/set사용
 * }
 */

class K
{
    int[] num = new int[4];
    public int this[int i]  // 해당키워드를 통해 내부정보 접근
    {
        get
        {
            return num[i];
        }
        set
        {
            num[i] = value;  // set 객체
        }
    }
}

namespace Indexer_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            K kk = new K();
            kk[0] = 123;
            kk[1] = 486;
            kk[2] = 383;
            kk[3] = 777;
            for (int i = 0; i < 4; i++)
                Console.WriteLine(kk[i]);
        }
    }
}
