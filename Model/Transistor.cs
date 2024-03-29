using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook_of_radio_amateurs
{
    public class Transistor: Detail
    {
        public string Type {  get; set; }
        public int Voltage { get; set; }
        public int Current {  get; set; }
    }
}
