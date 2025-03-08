using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MastermindLibrary
{
    public class Giocatore
    {
        private int _counter = 0;
        private Bot _computer = new Bot();

        public string Nome
        {
            get
            {
                return Nome;
            }
            private set { }
        }

        public int PartiteVinte
        {
            get
            {
                return PartiteVinte;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Le partite vinte non possono andare sotto lo 0");
                }
            }
        }

        public Giocatore(string nome, int partiteVinte = 0)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentNullException("il nome non può contenere spazi vuoti");
            }
            else
            {
                Nome = nome;
            }

            if (partiteVinte < 0)
            {
                throw new ArgumentOutOfRangeException("le partite vinte non possono essere negative");
            }
            else
            {
                PartiteVinte = partiteVinte;
            }
        }

        public Giocatore()
        {
            Nome = "Giocatore"+_counter;
        }
    }
}