using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class purse
{
    public static int money = 0;
    public void printmoney(int in_m, int out_m)
    {
        money = money + in_m - out_m;
        if (money < 0)
        {
            Console.WriteLine((-1 * money) + "원이 모자랍니다.");
        }
        else
        {
            Console.WriteLine(money + "원이 있습니다.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        purse store1 = new purse();
        purse store2 = new purse();
        store1.printmoney(1000, 100);
        store2.printmoney(0, 250);
        store1.printmoney(0, 800);
        Console.WriteLine(purse.money);
    }
}
