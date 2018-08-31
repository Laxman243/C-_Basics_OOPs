using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InheritanceExample
    {
        int BranchId;
        string BranchName;
    
        public void GetData()
        {
            Console.WriteLine("Enter branchId");
            this.BranchId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter branchName");
            this.BranchName = Console.ReadLine();
        }
        public void DisplayData()
        {
            Console.WriteLine("enter branchId :" + BranchId);
            Console.WriteLine("enter branchName :" + BranchName);
        }
    }
    class B : InheritanceExample
    {
        string BranchAddress;
        int BranchPincode;

        public void GetData1()
        {
            Console.WriteLine("Enter branchAddress");
            this.BranchAddress = Console.ReadLine();
            Console.WriteLine("Enter branchPincode");
            this.BranchPincode = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayData1()
        {
            Console.WriteLine("Branch Address :" + BranchAddress);
            Console.WriteLine("Branch pincode :" + BranchPincode);
        }
    }
    class Inheritance
    {
        static void Main()
        {
            B obj = new B();
            Console.WriteLine("details");
            obj.GetData();
            obj.GetData1();
            obj.DisplayData();
            obj.DisplayData1();
            Console.ReadLine();
        }
    }
}
