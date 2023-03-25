using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admin.Property
{
    public class ItemProperty
    {
        public int CatID
        {
            get;
            set;
        }
        public int ItmID
        {
            get; set;
        }
        public string CatName
        {
            get; set;
        }
        public string ItmName
        {
            get; set;
        }
        public decimal ItmPrice
        {
            get; set;
        }
        public string ItmImage
        {
            get; set;
        }
        public string ItmDiscription
        {
            get; set;
        }
        public int CookingTime { get; set; }
        public string status { get; set; }
    }
}
