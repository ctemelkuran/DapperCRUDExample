using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUDExample
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public int Birth { get; set; }

        public string ActorFullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
