using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b.Singletone
{
    internal class GazolineCarDeveloper : CarDeveloper
    {
        public GazolineCarDeveloper(string company) : base(company){}

        public override Car Create()
        {
            return new GasolineCar();
        }
    }
}
