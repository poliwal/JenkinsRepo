using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSecondApplication
{
    interface INormalCal
    {
        //public and abstract
        int Add(int x, int y);
        int Sub(int x, int y);

    }
    class Calculator : INormalCal,ISciCal
    {
        int INormalCal.Add(int x,int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        int ISciCal.Add(int x, int y)
        {
            return x + y;
        }
        public int Mul(int x, int y)
        {
            return x * y;
        }
    }
    class InterfaceEg
    {
        static void Main()
        {
            INormalCal normalCal = new Calculator();
            Console.WriteLine($"Addition of Normal Calc: {normalCal.Add(10, 20)}");
            Console.WriteLine($"Addition of Normal Calc: {normalCal.Sub(10, 20)}");
            ISciCal sciCal = new Calculator();
            Console.WriteLine($"Addition of Normal Calc: {sciCal.Add(10, 20)}");
            Console.WriteLine($"Addition of Normal Calc: {sciCal.Mul(10, 20)}");
        }
        
    }
}
