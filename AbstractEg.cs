using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSecondApplication
{
    abstract class RBI
    {
        string rule = "Customer should have aadhar card.";

        //Abstract class
        abstract public int HomeLoan();
        abstract public int EduLoan();

        //Non Abstract methods can also be written
        internal void Rules()
        {
            Console.WriteLine($"Rule to be followed by all banks: {rule}");
        }
    }

    abstract class SBI: RBI
    {
        //sbi abstract method
        abstract public void SBICustomer();

        //rbi abstract method
        public override int HomeLoan()
        {
            return 10;
        }

        public override int EduLoan()
        {
            return 9;
        }
    }
    class SBIBranch : SBI
    {
        public override void SBICustomer()
        {
            Console.WriteLine("It has 1 Lakh Customers.");
        }
    }
    class AbstractEg
    {
        static void Main()
        {
            //SBI sbi = new SBI();
            //sbi.HomeLoan();
            //sbi.EduLoan();
            //sbi.Rules();

            /*
            SBIBranch sBIBranch = new SBIBranch();
            Console.WriteLine(sBIBranch.HomeLoan());
            Console.WriteLine(sBIBranch.EduLoan());
            sBIBranch.SBICustomer();
            sBIBranch.Rules();
            */

            //run time polymorphism

            //reference of parent class
            RBI rBI = new SBIBranch();
                      //object of child class
            Console.WriteLine(rBI.HomeLoan());
            Console.WriteLine(rBI.EduLoan());

            SBI sBI = new SBIBranch();
            sBI.SBICustomer();

            sBI.Rules();
            rBI.Rules();
        }
    }
}
