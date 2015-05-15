using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Dependency_Injection_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageWriter writer=new ConsoleMessageWriter();
            var salutation = new Salutation(writer);
            salutation.Exclaim();
            Console.ReadKey();
        }
    }
}
