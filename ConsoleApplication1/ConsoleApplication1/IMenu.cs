﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IMenu
    {
        string Add(IPeople person);
        string Remove(string name);
        string Sort();
        void Print();
        string SaveToFile();
        string LoadFromFile();
    }
}
