using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjectionProject
{
    public class IlkClass : IMesajlaClass
    {
        public void MesajAt(string mesaj)
        {
            Console.WriteLine("İlk claass'tan mesaj :  " + mesaj);
        }
    }
}
