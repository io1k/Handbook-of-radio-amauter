using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook_of_radio_amateurs
{
    public class Capasitor: Detail
    {
        public int Capasity {  get; set; }
        public int AllowablePowerable { get; set; }
        public string Type {  get; set; }
        
    }
}
