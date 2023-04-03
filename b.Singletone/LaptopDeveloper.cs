using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b.Singletone
{
    class LaptopDeveloper : ComputerDeveloper
    {
        public LaptopDeveloper(string piece1, string piece2) : base(piece1, piece2)
        { }
        public override Computer Create()
        {
            return new Laptop();
        }
    }
}
