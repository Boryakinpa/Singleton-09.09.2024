using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;

namespace Singleton
{
    public class Server
    {
        internal string Adress { get; private set; } = "";

        internal Server(string adress)
        {
            Adress = adress;
        }
    }
}
