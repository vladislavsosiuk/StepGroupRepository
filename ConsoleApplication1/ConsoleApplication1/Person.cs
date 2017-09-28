using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [Serializable]
    public class Person : IPeople
    {
        string address;
        string name;
        string phone;

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
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
        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public Person(string n, string ph, string addr)
        {
            Name = n;
            Phone = ph;
            Address = addr;
        }
        public override string ToString()
        {
            return $" {Name}, {Phone}, {Address}";
        }
    }
}
