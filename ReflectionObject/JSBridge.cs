using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionObject
{
    public static class JSBridge
    {
        private static IWebBrowser m_browser;
        private static Dictionary<string, ObjectInfo> m_info_objects = new Dictionary<string, ObjectInfo>();
        private static Dictionary<string, object> m_objects = new Dictionary<string, object>();

        public static void EnableJSBridge(IWebBrowser browser)
        {
            m_browser = browser;
            if (m_browser == null)
            {
                throw new ArgumentNullException("IWebBrowser cannot be null");
            }
        }

        public static void RegisterObject(string name, object obj)
        {
            if (!m_info_objects.ContainsKey(name))
            {
                ObjectInfo info = ReflectionHelper.GetObjectInfo(name, obj);
                m_info_objects.Add(name, info);
                m_objects.Add(name, obj);
            }
        }

        public static void DeRegisterObject(string name)
        {
            if (m_info_objects.ContainsKey(name))
            {
                m_info_objects.Remove(name);
                m_objects.Remove(name);
            }
        }


        private static void InjectJSEnvironment()
        {
            if (m_browser.PageIsLoaded())
            {
                m_browser.ExecuteJavaScript("");
                UpdateObjectsInBrowser();
            }
        }

        public static void UpdateObjectsInBrowser()
        {
            foreach (string key in m_info_objects.Keys)
            {
                string objstr = m_info_objects[key].Serialize();
                string js = string.Format("var tobj = new CSObject('{0}'); tobj.create(); tobj.RunMethod(100,true)", objstr);
                m_browser.ExecuteJavaScript(js);
            }
            //m_browser.ExecuteJavaScript("alert('LOL' + (typeof tobj));");
        }

        public static JsReturn RaiseEvent(JsTelegram telegram)
        {
            object ret = null;
            string name = telegram.ObjName;
            object obj = m_objects[name];
            Type t = obj.GetType();
            ObjectInfo info = m_info_objects[name];

            System.Reflection.MethodInfo method = t.GetMethod(telegram.MethodName);
            ret = method.Invoke(obj, telegram.Parameters.ToArray());

            return JsReturn.Return(ret);
        }
    }
}
