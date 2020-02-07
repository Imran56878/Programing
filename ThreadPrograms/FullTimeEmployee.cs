using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadPrograms
{
    class FullTimeEmployee
    {
       public  int Id { get; set; }
       public  string fName { get; set; }
       public  string lName { get; set; }
       public  int annualSalary { get; set; }
        public string GetFullName()
        {
            return this.fName + " " + lName;
        }
        public int Monthlysalary()
        {
            return this.annualSalary / 12;
        }
    }
}
