using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVendas.Models
{
    public class Employee : Customer
    {
        public String Password { get; set; }
        public String Occupation { get; set; }
        public String AccessLevel { get; set; }

    }
}
