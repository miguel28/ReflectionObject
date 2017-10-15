using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionObject
{
    public class IEBrowser : WebBrowser, IWebBrowser
    {
        public IEBrowser() : base()
        {
            
        }

        protected override void OnNavigating(WebBrowserNavigatingEventArgs e)
        {
            base.OnNavigating(e);
            Console.WriteLine(e.Url.ToString());
        }

        public void ExecuteJavaScript(string code)
        {
            base.Document.InvokeScript("eval", new object[] { code });
        }

        public bool PageIsLoaded()
        {
            return ReadyState == WebBrowserReadyState.Complete;
        }
    }
}
