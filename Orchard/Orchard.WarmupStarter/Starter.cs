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

        public Starter(Func<HttpApplication,T> initialization)
        {
            _initialization = initialization;
        }

    }
}
