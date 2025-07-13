using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVendas.Models
{
    public class Sales
    {
        public int id { get; set; }
        public  int cliente_id { get; set; }
        public DateTime sale_date { get; set; }
        public decimal total_sales {  get; set; }
        public string obs {  get; set; }
    }
}
