using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;

namespace MastermindLibrary
{
    public class Gioco
    {
        const int NUM_TENTATIVI = 9;
        const int NUM_PALLINE = 4;

        private Bot _computer;
        private int _tentativiFatti = 0;
        private int _pallineNere = 0;
        private ColoriDellaSequenza[] _soluzione = new ColoriDellaSequenza[NUM_PALLINE];
        private ColoriDellaSequenza[] _risultatoInvio = new ColoriDellaSequenza[NUM_PALLINE];
        private Giocatore _giocatore;
        public int TentativiRimanenti
        {
            get
            {
                return NUM_TENTATIVI - _tentativiFatti;
            }
        }
        public Gioco(Giocatore giocatore, FixedGenerator? generator = null)
        {
            _computer = new Bot();
            _giocatore = new Giocatore(giocatore.Nome);

            if(generator != null)
            {
                _soluzione = generator.GeneraCodice();
            }
            else
            {
                _soluzione = _computer.GeneraCodice();
            }
        }

        public ColoriDellaSequenza[] ControllaTentativo(ColoriDellaSequenza[] sequenzaInviata)
        {
            _tentativiFatti++;
            ColoriDellaSequenza[] risultato = new ColoriDellaSequenza[NUM_PALLINE];
            for (int i = 0; i < sequenzaInviata.Length; i++)
            {
                if (sequenzaInviata[i] == _soluzione[i])
                {
                    risultato[i] = ColoriDellaSequenza.NERO;
                }
                else if (_soluzione.Contains(sequenzaInviata[i]))
                {
                    risultato[i] = ColoriDellaSequenza.BIANCO;
                }
                else
                {
                    risultato[i] = ColoriDellaSequenza.NULL;
                }
            }
            return risultato;
        }
    }
}