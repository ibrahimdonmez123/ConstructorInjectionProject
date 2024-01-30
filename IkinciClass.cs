using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjectionProject
{
    public class IkinciClass
    {
        IMesajlaClass _oIMesajlaClass = null;

        public IkinciClass(IMesajlaClass oIMesajlaClass)
        {
            _oIMesajlaClass = oIMesajlaClass;
        }
        public void MesajıGoster(string mesaj)
        { 
            if (_oIMesajlaClass == null)
            {
            Console.WriteLine("Ikinci class'tan mesaj : " + mesaj);
            }
            _oIMesajlaClass.MesajAt(mesaj);
        }
}
}
