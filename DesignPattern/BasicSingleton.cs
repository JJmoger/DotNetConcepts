using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class BasicSignleton
    {
        private static BasicSignleton _instance;
        private static readonly object _lock = new object();

        private BasicSignleton(){}

        public static BasicSignleton Instance {  get 
            {
                lock (_lock)
                {
                    if ( _instance == null) 
                    { 
                        _instance = new BasicSignleton();
                    }
                    return _instance;
                }
            } 
        }
    }
}
