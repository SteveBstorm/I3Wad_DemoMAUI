using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMAUI.Components.Pages.Exercice
{
    public partial class Quizz
    {
        public string Prenom { get; set; }

        public List<string> Reponse { get; set; }
        public Quizz()
        {
            Reponse = new List<string>();
        }

        public void EnregisterReponse(bool rep)
        {
            Reponse.Add(rep ? "Oui" : "Non");
        }

        public bool PartieTerminee { get; set; } = false;

        public void ChangerEtatPartie()
        {
            PartieTerminee = true;
        }
    }
}
