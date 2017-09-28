using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Menu : IMenu
    {
        List<IPeople> people;
        public List<IPeople> People
        {
            get
            {
                return people;
            }
            set
            {
                people = value;
            }
        }
        public void Add(IPeople person)
        {
            People.Add(person);
        }

        public List<IPeople> LoadFromFile()
        {
            List<IPeople> res;
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("Peop.dat", FileMode.OpenOrCreate))
            {
                res = (List<IPeople>)bf.Deserialize(fs);
            }
            return res;
        }

        public void Print()
        {
            foreach(var r in People)
            {
                Console.WriteLine(r);
            }
        }

        public void Remove(IPeople person)
        {
            for(int i = 0; i < People.Count; i++)
            {
                if (person.Name == People[i].Name)
                    People.RemoveAt(i);
            }
        }

        public void SaveToFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("Peop.dat", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, People);
            }
        }



        void IMenu.Sort(object parameter)
        {
            list.Sort(delegate (People a, People b) { return a.Name.CompareTo(b.Name); });
        }


    }
}
