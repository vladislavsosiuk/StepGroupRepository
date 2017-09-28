using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IMenu
    {
        void Add(IPeople person);
        void Remove(IPeople person);
        void Sort(object parameter);
        void Print();
        void SaveToFile(List<IPeople> people);
        List<IPeople> LoadFromFile(string fileName);
    }
}
