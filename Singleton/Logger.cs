using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        //Thread Safe with Lazy<T> during initialization
        public static readonly Lazy<Logger> LazyInstance =
            new(() => new Logger());
        private Logger()
        {
        }

        public static Logger GetInstance => LazyInstance.Value;

        //private static Logger? _instance;
        //public static Logger GetInstance() 
        //{
        //    if (_instance == null)
        //    {
        //        _instance = new Logger();
        //    }

        //    return _instance;
        //}

        ///SingletonOperation
        ///
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
