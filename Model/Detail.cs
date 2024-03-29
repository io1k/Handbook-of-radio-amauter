using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook_of_radio_amateurs
{ 

    public abstract class Detail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        /*
        public abstract List<Detail> Find(string s);
        */
    }
}
