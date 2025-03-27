using MastermindLibrary;

namespace TestMastermind
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Giocatore giocatore1 = new Giocatore("susususup");
            Bot bot1 = new Bot();
            FixedGenerator fixedGenerator = new FixedGenerator();
            Gioco gioco = new Gioco(giocatore1, fixedGenerator);

            Pallina[] sequenza =
            [
                new Pallina(ColoriDellaSequenza.ROSSO, 1),
                new Pallina(ColoriDellaSequenza.ROSSO, 2),
                new Pallina(ColoriDellaSequenza.ROSSO, 3),
                new Pallina(ColoriDellaSequenza.ROSSO, 4),
            ];

            Pallina[] sequenza2 =
            [
                new Pallina(ColoriPerControllare.NERO, 1),
                new Pallina(ColoriPerControllare.NERO, 2),
                new Pallina(ColoriPerControllare.NERO, 3),
                new Pallina(ColoriPerControllare.NERO, 4),
            ];
            Assert.AreEqual(sequenza2, gioco.ControllaTentativo(sequenza));
        }

        [TestMethod]
        public void Gioco_TentativoParzialmenteSbagliato_RitornaSequenzaNeraBianca()
        {
            Giocatore giocatore1 = new Giocatore("susususup");
            Bot bot1 = new Bot();
            FixedGenerator fixedGenerator = new FixedGenerator();
            Gioco gioco = new Gioco(giocatore1, fixedGenerator);

            Pallina[] sequenza =
            [
                new Pallina(ColoriDellaSequenza.ROSSO, 1),
                new Pallina(ColoriDellaSequenza.BLU, 2),
                new Pallina(ColoriDellaSequenza.ROSSO, 3),
                new Pallina(ColoriDellaSequenza.ROSSO, 4),
            ];

            Pallina[] sequenza2 =
            [
                new Pallina(ColoriPerControllare.NERO, 1),
                new Pallina(ColoriPerControllare.NULL, 2),
                new Pallina(ColoriPerControllare.NERO, 3),
                new Pallina(ColoriPerControllare.NERO, 4),
            ];
            Assert.AreEqual(sequenza2, gioco.ControllaTentativo(sequenza));
        }
    }
}