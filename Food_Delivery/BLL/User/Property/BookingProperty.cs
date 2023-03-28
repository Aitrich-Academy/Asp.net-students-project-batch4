using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.User.Property
{
    public class BookingProperty
    {
        public int BookID { get; set; }
        public int ItmID { get; set; }
        public string ItmName { get; set;}
        public string UName { get; set; }
        public string Email { get; set; }
        public int CatID { get; set; }
        public int UID { get; set; }

        public int Qty { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
    }
}
