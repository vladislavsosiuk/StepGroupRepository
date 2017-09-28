using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface IMenu
    {
        string Add(IPeople person);
        string Remove(string name);
        string Sort(object parameter);
        void Print();
        string SaveToFile();
        string LoadFromFile();
    }
}
