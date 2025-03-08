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

        public Pallina[] sequenza;

        public Bot()
        {
            sequenza = new Pallina[NUM_PALLINE];
        }

        public int NumeroColori
        {
            get
            {
                return NumeroColori;
            }
            private set { }
        }

        public Pallina[] GeneraCodice()
        {
            Random random = new Random();

            for (int i = 0; i < sequenza.Length; i++)
            {
                int numero = random.Next(1, 6); //genera un numero da 1 a 5

                if (i == 0)
                {
                    if (numero == 1)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.ROSSO, i + 1);
                    }
                    else if (numero == 2)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.ARANCIONE, i + 1);
                    }
                    else if (numero == 3)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.GIALLO, i + 1);
                    }
                    else if (numero == 4)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.VERDE, i + 1);
                    }
                    else if(numero == 5)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.BLU, i + 1);
                    }
                } 
                else if (i == 1)
                {
                    if (numero == 1)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.ROSSO, i + 1);
                    }
                    else if (numero == 2)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.ARANCIONE, i + 1);
                    }
                    else if (numero == 3)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.GIALLO, i+1);
                    }
                    else if (numero == 4)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.VERDE, i + 1);
                    }
                    else if (numero == 5)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.BLU, i + 1);
                    }
                }
                else if (i == 2)
                {
                    if (numero == 1)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.ROSSO, i + 1);
                    }
                    else if (numero == 2)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.ARANCIONE, i + 1);
                    }
                    else if (numero == 3)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.GIALLO, i + 1);
                    }
                    else if (numero == 4)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.VERDE, i + 1);
                    }
                    else if (numero == 5)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.BLU, i + 1);
                    }
                }
                else if (i == 3)
                {
                    if (numero == 1)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.ROSSO, i + 1);
                    }
                    else if (numero == 2)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.ARANCIONE, i + 1);
                    }
                    else if (numero == 3)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.GIALLO, i + 1);
                    }
                    else if (numero == 4)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.VERDE, i + 1);
                    }
                    else if (numero == 5)
                    {
                        sequenza[i] = new Pallina(ColoriDellaSequenza.BLU, i + 1);
                    }
                }
            }

            return sequenza;
        }
    }
}