using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int NumberChanger(int n);

namespace DelegateExample
{
    class TestDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int SubtractNum(int x)
        {
            num -= x;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum); // <-- Notice parameters are methods.
            NumberChanger nc2 = new NumberChanger(MultNum);
            NumberChanger nc3 = new NumberChanger(SubtractNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum()); // returns 35
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum()); // returns 175
            nc3(10);
            Console.WriteLine("Value of Num: {0}", getNum()); // returns 165
            nc1(-175);
            Console.WriteLine("Value of Num: {0}", getNum()); // returns -10
            Console.ReadKey();
        }
    }
}
