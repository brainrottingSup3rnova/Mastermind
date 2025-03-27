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

        public Giocatore(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentNullException("il nome non può contenere spazi vuoti");
            }
            else
            {
                Nome = nome;
            }
        }

        public Giocatore()
        {
            Nome = "Giocatore"+_counter;
        }
    }
}