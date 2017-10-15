using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionObject
{
    public interface IWebBrowser
    {
        void ExecuteJavaScript(string code);
        bool PageIsLoaded();
    }
}
