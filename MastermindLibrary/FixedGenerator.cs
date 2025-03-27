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

        public ColoriDellaSequenza[] GeneraCodice()
        {
            ColoriDellaSequenza[] sequenza =
                {
                    ColoriDellaSequenza.ROSSO,
                    ColoriDellaSequenza.ROSSO,
                    ColoriDellaSequenza.ROSSO,
                    ColoriDellaSequenza.ROSSO,
                };
            return sequenza;
        }
    }
}
