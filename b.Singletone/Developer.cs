using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b.Singletone
{
    abstract class CarDeveloper
    {
        public string Company { get; set; }
        public CarDeveloper(string company)
        {
            Company = company;
        }
        public abstract Car Create();

    }
}
