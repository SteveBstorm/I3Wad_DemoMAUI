using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMAUI.Components.Pages
{
    public partial class PetitComposant
    {
        [Parameter]
        public string ValeurDeDemo2 { get; set; }

        [Parameter]
        public EventCallback<string> Reponse { get; set; }

        public void RepondADemo2()
        {
            Reponse.InvokeAsync(
                "La réponse fournie par le pti");
        }
    }
}
