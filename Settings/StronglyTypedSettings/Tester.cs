using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StronglyTypedSettings
{
    public class Tester
    {

        public Tester()
        {
            var settings = new Configs();

            Configs.Lookup = s => s;
            Configs.WriteBack = (k, v) => {};

            var x = settings.Global.Login.Retries;
        }

    }

    
}
