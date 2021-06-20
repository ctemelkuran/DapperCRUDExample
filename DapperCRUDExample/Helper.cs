using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace DapperCRUDExample
{
    public static class Helper
    {
        // When we say Helper.CnnVal("name of the configstring") it will look to app.config for that connection string
        // DONT Forget to add Configuration Reference
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
