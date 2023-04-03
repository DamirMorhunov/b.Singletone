using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b.Singletone
{
   
    class Singletone
    {
        static Singletone _instance;
        public string Name { get; set; }
        private Singletone(string name)
        {
            Name = name;
        }
        public static Singletone GetInstance(string name)
        {
            if(_instance is null)
                _instance = new Singletone(name);
            return _instance;
        }

    }
}
