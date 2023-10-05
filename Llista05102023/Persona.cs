using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Llista05102023
{
    class persona
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public persona(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

}
