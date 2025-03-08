using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MastermindLibrary
{
    public class Pallina
    {
        public ColoriDellaSequenza? ColoreDaGioco // nullable perchè se si crea una pallina di controllo questo campo non serve
        {
            get
            {
                return ColoreDaGioco;
            }
            set { }
        }

        public ColoriPerControllare? ColoreDiControllo // nullable perchè se si crea una pallina da gioco questo campo non serve
        {
            get
            {
                return ColoreDiControllo;
            }
            set { }
        }

        public int Posizione
        {
            get
            {
                return Posizione;
            }
            set { }
        }

        public Pallina(ColoriDellaSequenza colore, int posizione) //per creare una pallina da gioco 
        {
            ColoreDaGioco = colore;
            Posizione = posizione;
            ColoreDiControllo = null;
        }

        public Pallina(ColoriPerControllare colore, int posizione) // per creare una pallina di controllo
        {
            ColoreDiControllo = colore;
            Posizione = posizione;
            ColoreDaGioco = null;
        }
    }
}