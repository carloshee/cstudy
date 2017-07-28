using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 가상메서드, 오버라이딩
  기반클래스의 메서드를 파생클래스에서 변형(재정의)해서 사용하기 위한 방법
  형식
 1) 부모클래스
  메서드에 virtual 키워드를 넣는다.
  권한 virtual 리턴타입 메서드이름(파라미터)
  {
        내부로직구현
  }   // 현재클래스는 이대로 사용
        
         파생클래스는 재정의해서 사용
 2) 자식클래스
   메서드에 override 키워드를 넣는다.
   권한 override 리턴타입 메서드이름(파라미터)
   {
        내부로직구현
   }

 */

//cf) 일바적인 virtual 의 의미..가상.. (추상화) => chap 추상화클래스
// => 현재 구현이 안되고 파생클래스가 구현된다.
// 부모클래스는 정의만 내림... (예측)
// 자식클래스가 재정의 하는것을 요청함 (재정의할것이 없으면 권한이 )
// 가상 메서드 virtual 의 특징
// 메서드가 private static 안됨
// 부모 자식 문법 구조가 같아야 한다.
// 기반클래스에서 정의한 것을 자식클래스에서 재정의 한다. => virtual이 있어야 override가 있다.
// cf) virtual 만 있으면 ... 파생클래스에서 override가 되어있으면 오버라이드 된 메서드 실행
// 없으면 ... virtual 로 된 메서드 실행

class parent
{
    public virtual void ShowData()
    {
        Console.WriteLine("부모의 기능");
    }
}

class child : parent
{
    public virtual void SetData()
    {
        Console.WriteLine("--------");
    }
    public override void ShowData()
    {
        Console.WriteLine("개선된 자식의 기능");
    }
    
}

class Child2 : child
{
    public override void SetData()
    {
        Console.WriteLine("--------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        parent p = new parent();
        p.ShowData();
        child c = new child();
        c.SetData();
        c.ShowData();
    }
}
