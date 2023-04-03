using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b.Singletone
{
    abstract class ComputerDeveloper
    {
        public string Piece1{ get; set; }
        public string Piece2{ get; set; }
        public ComputerDeveloper(string piece, string piece2)
        {
            Piece1 = piece;
            Piece2 = piece2;
        }
        public abstract Computer Create();
    }
}
