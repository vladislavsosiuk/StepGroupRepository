﻿using System;
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
        public Menu()
        {
            People = new List<IPeople>();
        }
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
       

       

        public void Print()
        {
            foreach(var r in People)
            {
                Console.WriteLine(r);
            }
        }

        public string Remove(string name)
        {
            IPeople person = People.Find(p => p.Name == name);
            if (person != null)
            {
                People.Remove(person);
                return "removed";
            }
            else
                return "not found";
        }

        public void Remove(IPeople person)
        {
            for(int i = 0; i < People.Count; i++)
            {
                if (person.Name == People[i].Name)
                    People.RemoveAt(i);
            }
        }
        
        public string Add(IPeople person)
        {
            People.Add(person);
            return "Added";
        }

        public string LoadFromFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("Peop.dat", FileMode.OpenOrCreate))
            {
                People = (List<IPeople>)bf.Deserialize(fs);
            }
            return "Loaded";
        }

        public string SaveToFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("Peop.dat", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, People);
            }
            return "Saved";
        }
        public string  Sort()
        {
            People.Sort((a, b) => a.Name.CompareTo(b.Name));
            return "Sorted";
        }
        
    }
}
