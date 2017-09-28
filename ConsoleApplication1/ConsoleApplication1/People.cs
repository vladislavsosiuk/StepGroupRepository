using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public  class People : IPeople
    {
      public   string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

      
         
    }

    public class Menu : IMenu
    {
        List<People> list;
       

        void IMenu.Add(IPeople person)
        {
            throw new NotImplementedException();
        }

        void IMenu.Remove(IPeople person)
        {
            throw new NotImplementedException();
        }

        void IMenu.Sort(object parameter)
        {
            list.Sort(delegate (People a, People b) { return a.Name.CompareTo(b.Name); });
        }

        void IMenu.Print()
        {
            foreach (People i in list)
            {
                Console.WriteLine("Name: " + i.Name + "   Phone: " + i.Phone + "Adress:" + i.Address);
            }
        }

        void IMenu.SaveToFile(List<IPeople> people)
        {
            throw new NotImplementedException();
        }

        List<IPeople> IMenu.LoadFromFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }
  


}
