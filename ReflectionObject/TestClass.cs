using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionObject
{
    public class TestClass
    {
        public string Property = "";
        public void RunMethod(int param1, bool param2)
        {
            Console.WriteLine(param1.ToString() + param2.ToString());
        }
    }
}
