using MastermindLibrary;
namespace MastermindTest
{
    [TestClass]
    public class GiocoTest
    {
        [TestMethod]
        public void Gioco_TentativoGiusto_RitornaSequenzaFullNera()
        {
            Giocatore giocatore1 = new Giocatore("susususup", 0);
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
            Assert.AreEqual( sequenza2, gioco.ControllaTentativo(sequenza));
        }

        [TestMethod]
        public void Gioco_TentativoParzialmenteSbagliato_RitornaSequenzaNeraBianca()
        {
            Giocatore giocatore1 = new Giocatore("susususup", 0);
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