using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Employee
    {
        public double Salary { get; set; }
        private string _name;
        public string Name
        {
            set
            { if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
            get { return _name; }
        }

        private int _birthday;
        public int BirthDay
        {
            get {return _birthday;}
        }

        public int Age
        {
            get { return DateTime.Now.Year - BirthDay; }
        }
    }
}
