using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 멤버변수 같이 보이지만 실제는 메서드의 동작이다.
 * get, set 접근자로 로직을 작성한다.
 * 메서드타입으로 동작하기 때문에
 * static과 추상화 키워드를 쓸 수 없다.
 * 내부적으로는 메모리를 추가할당하지 않는다.
 */
 /*
   권한 자료형 자료형 이름
   {//메서드를 의미
        get     -> 얻는다.. =>값을 넘겨준다
        {//메서드를 의미
            return 값이 필요
        }
        set     -> 세팅한다.    => 변수에다... 프로퍼티를 통해 얻은 값을 대입한다.
        {
            값을 넣을 변수 = 프로퍼티이름 : 
                            (해당 로직으로 얻은 세팅값)
        }
   }
 */

class AA
{
    private int _m_a; //멤버 변수
    //
    public int m_a  //get, set 기능을 쓸... 변수 같아보이는 메서드
                    //변수이름 = 메서드이름
    {
        get
        {
            return _m_a;
        }
        set
        {
            _m_a = m_a;
        }
    }
}

namespace Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28);

            Console.WriteLine("Name : {0}", birth.Name);
            Console.WriteLine("Birthday : {0}", birth.Birthday.ToShortDateString());
            Console.WriteLine("Age : {0}", birth.Age);
        }
    }
}
