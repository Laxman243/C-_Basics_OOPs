using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AbstractionExample
    {
        int EmpId;
        string EName;
        string EAddress;
        int EAge;

        public int PEmpId
        {
            set { EmpId = value; }
            get { return EmpId; }
        }
        public string PEName
        {
            set { EName = value; }
            get { return EName; }
        }
        public string PEAddress
        {
            set { EAddress = value;  }
            get { return EAddress; }
        }
        public int PEAge
        {
            set { EAge = value; }
            get { return EAge; }
        }
    }
}
