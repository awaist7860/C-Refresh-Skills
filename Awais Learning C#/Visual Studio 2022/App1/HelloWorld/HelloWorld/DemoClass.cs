using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("This is the first interface classes myMthod()");
        }

        public void myMethod2()
        {
            Console.WriteLine("This is the second interface classes myMethod2()");
        }
    }
}
