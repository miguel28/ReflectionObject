using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReflectionObject
{
    public partial class Form1 : Form
    {
        private TestClass testObj = new TestClass();
        public Form1()
        {
            InitializeComponent();
            string curDir = Directory.GetCurrentDirectory();
            webBrowser1.Url = new Uri(String.Format("file:///{0}/page.html", curDir));

            JSBridge.RegisterObject("testObj", testObj);
            JSBridge.EnableJSBridge(webBrowser1);
            
        }

        private void btnChangePropertly_Click(object sender, EventArgs e)
        {

        }

        private void btnCallMethod_Click(object sender, EventArgs e)
        {
            testObj.Property = "";

            JsTelegram t = new JsTelegram();
            t.ObjName = "testObj";
            t.MethodName = "RunMethod";
            t.Parameters.Add(10);
            t.Parameters.Add(false);

            JSBridge.RaiseEvent(t);

            Console.WriteLine(testObj.Property);
        }

        private void btnCallJava_Click(object sender, EventArgs e)
        {
            //webBrowser1.ExecuteJavaScript("var ss = 'Bye';");
            //webBrowser1.ExecuteJavaScript("alert(ss)");
            //webBrowser1.ExecuteJavaScript("alert('C# Rocks!')");
            webBrowser1.ExecuteJavaScript("var tobj = CSObject");
        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            JSBridge.UpdateObjectsInBrowser();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
