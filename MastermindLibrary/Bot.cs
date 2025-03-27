using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MastermindLibrary
{
    public class Bot
    {
        const int NUM_TENTATIVI = 9;
        const int NUM_PALLINE = 4;

        public ColoriDellaSequenza[] sequenza;

        public Bot()
        {
            sequenza = new ColoriDellaSequenza[NUM_PALLINE];
        }

        public int NumeroColori
        {
            get
            {
                return NumeroColori;
            }
            private set { }
        }

        public ColoriDellaSequenza[] GeneraCodice()
        {
            Random random = new Random();
            ColoriDellaSequenza[] sequenzaColori = new ColoriDellaSequenza[NUM_PALLINE];

            for (int i = 0; i < sequenzaColori.Length; i++)
            {
                int numero = random.Next(1, 6); // genera un numero da 1 a 5
                sequenzaColori[i] = (ColoriDellaSequenza)(numero - 1);
            }
            return sequenzaColori;
        }
    }
}