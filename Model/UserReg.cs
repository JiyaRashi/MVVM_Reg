using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Reg.Model
{
    public class UserReg
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public Enum Language { get; set; }
        public Int64 MobileNumer { get; set; }
        public IList<string> Country { get; set; }
        public int PinCode { get; set; }

    }

    
}
