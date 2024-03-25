using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMAUI.Components.Pages
{
    public partial class Demo1
    {
        public int Number { get; set; }
        public int Value { get; set; }

        public void AddValue()
        {
            Number += Value;
        }
        public void Increment()
        {
            Number++;
        }
        public void Decrement()
        {
            Number--;
        }
    }
}
