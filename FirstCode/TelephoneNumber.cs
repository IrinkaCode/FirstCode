using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    internal class TelephoneNumber
    {
        public int Id {  get; set; }
        public string Number { get; set; }
        public TelephoneNumber() { }
        public TelephoneNumber(string number)
        {
            Number = number;
        }
    }
}
