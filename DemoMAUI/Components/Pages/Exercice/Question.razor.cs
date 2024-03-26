using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMAUI.Components.Pages.Exercice
{
    public partial class Question
    {
        [Parameter]
        public string Prenom { get; set; }
        
        public List<string> Questions { get; set; }

        public string QuestionEnCours { get; set; }
        public int Compteur { get; set; }

        [Parameter]
        public EventCallback<bool> EnvoiReponse { get; set; }
        [Parameter]
        public EventCallback PartieFinie { get; set; }
        public Question()
        {
            Questions = new List<string>();
            Questions.Add("Aimez vous le developement ?");
            Questions.Add("Voulez vous de plus longue pause ?");
            Questions.Add("Etes vous triste de la fin de votre formation ?");

            Compteur = 0;
            QuestionEnCours = Questions[Compteur];
        }

        public void Repondre(bool reponse)
        {
            EnvoiReponse.InvokeAsync(reponse);
            Compteur++;
            if(Compteur >= Questions.Count())
            {
                PartieFinie.InvokeAsync();
            }
            else
            {
                QuestionEnCours = Questions[Compteur];
            }
        }

    }
}
