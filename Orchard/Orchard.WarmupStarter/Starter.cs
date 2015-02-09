using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Orchard.WarmupStarter
{
    public class Starter<T> where T : class
    {
        private readonly Func<HttpApplication, T> _initialization;
        private readonly Action<HttpApplication, T> _beginRequest;

        public Starter(Func<HttpApplication,T> initialization,Action<HttpApplication,T> beginRequest)
        {
            _initialization = initialization;
            _beginRequest = beginRequest;
        }

    }
}
