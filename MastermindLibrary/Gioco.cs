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
        private Pallina[] _soluzione = new Pallina[NUM_PALLINE];
        private Pallina[] _risultatoInvio = new Pallina[NUM_PALLINE];
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

        public Pallina[] ControllaTentativo(Pallina[] sequenzaInviata)
        {
            _tentativiFatti--;
            for (int i = 0; i < sequenzaInviata.Length; i++)
            {
                if (sequenzaInviata[i] == _computer.sequenza[i])
                {
                    _risultatoInvio[i] = new Pallina(ColoriPerControllare.NERO, i + 1);
                    _pallineNere++;
                }
                else if (sequenzaInviata[i].ColoreDaGioco == _computer.sequenza[i].ColoreDaGioco)
                {
                    _risultatoInvio[i] = new Pallina(ColoriPerControllare.BIANCO, i + 1);
                }
                else _risultatoInvio[i] = new Pallina(ColoriPerControllare.NULL, i + 1);
            }
            
            return _risultatoInvio;
        }

        public string? PartitaVinta()
        {   
            if(_pallineNere == NUM_PALLINE)
            {
                return ("Complimenti! Hai vinto!! Sei un vero sigma :3");
            }
            else
            {
                return null;
            }
        }

        public string? PartitaPersa()
        {
            if(TentativiRimanenti == 0)
            {
                return ("Mi dispiace...hai perso!");
            }
            else
            {
                return null; 
            }
        }
    }
}