using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace serializacja_i_deserializacja_Dawid_Ruth_58411
{
    [Serializable] //atrybut
    public class Customer
    {
       
        [Category("Information"), Description("Name of the customer")]
       public string Name { get; set; }
       
        [Category("Information"), Description("PESEL")]
        public long PESEL { get; set; }
       
        [Category("Information"), Description("Adress of the customer")]
        public string Adress { get; set; }
        
        [Category("Information"), Description("Age of the customer")]
        public int Age { get; set; }
        
        [Category("Information"), Description(" Has a discount")]
        public bool Discount { get; set; }

        [Category("Contact"), Description("Email adress of the customer")]
        public string Email { get; set; }
 
        [Category("Contact"), Description("Name of the customer")]
        public string Website { get; set; }
    }
}
