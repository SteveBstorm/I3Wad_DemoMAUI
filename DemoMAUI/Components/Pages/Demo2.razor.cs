using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMAUI.Components.Pages
{
    public partial class Demo2
    {
        public string ReponseDuPti { get; set; }

        public void RecevoirReponse(string r)
        {
            ReponseDuPti = r;
        }
    }
}
