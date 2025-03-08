using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindLibrary
{
    public class FixedGenerator : IGenerator
    {
        public FixedGenerator() { }

        public Pallina[] GeneraCodice ()
        {
            Pallina[] sequenza =
            [
                new Pallina(ColoriDellaSequenza.ROSSO, 1),
                new Pallina(ColoriDellaSequenza.ROSSO, 2),
                new Pallina(ColoriDellaSequenza.ROSSO, 3),
                new Pallina(ColoriDellaSequenza.ROSSO, 4),
            ];
            return sequenza;
        }
    }
}
