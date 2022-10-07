using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDI2.Entities
{
     class Person: Base
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Status StatusCivilian { get; set; }
        public int Age{ get; set; }
    }

    
}
