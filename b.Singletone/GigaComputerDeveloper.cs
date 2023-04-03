using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b.Singletone
{
    internal class GigaComputerDeveloper : ComputerDeveloper
    {
        public GigaComputerDeveloper(string piece1, string piece2) : base(piece1, piece2)
        { }
        public override Computer Create()
        {
            return new GigaComputer();
        }
    }
}
