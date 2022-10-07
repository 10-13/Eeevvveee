using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveEchoes.Bot
{
    internal interface IAlgorytm
    {
        //massive of requested data
        public bool Start();
        public Task StartAsync();
        public Type[] GetParamsTypes();
    }
}
