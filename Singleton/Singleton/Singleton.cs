using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        static Singleton uniqueInstance;
        string singletonData = string.Empty;
        private static Singleton instance = new Singleton();
        private static object syncRoot = new Object();
        List<string> servers = new List<string>();
        protected Singleton()
        {

        }
        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        public bool AddServer(Server server)
        {
            lock (syncRoot)
            {
                List<string> protocols = new List<string>() { "http:", "https" };
                if (!servers.Contains(server.Adress))
                {
                    foreach (string protocol in protocols)
                    {
                        if (server.Adress.StartsWith(protocol))
                        {
                            servers.Add(server.Adress);
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        public List<string> GetHttp()
        {
            List<string> serversHttp = new List<string>();
            foreach (string server in servers)
            {
                if (server.StartsWith("http:")) serversHttp.Add(server);
            }
            return serversHttp;
        }

        public List<string> GetHttps()
        {
            List<string> serversHttps = new List<string>();
            foreach (string server in servers)
            {
                if (server.StartsWith("https")) serversHttps.Add(server);
            }
            return serversHttps;
        }
    }
}
