using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement
{
    class CBBItem
    {
        public string VALUE { get; set; }
        public string TEXT { get; set; }
        public override string ToString()
        {
            return VALUE + " - " + TEXT;
        }
    }
}
