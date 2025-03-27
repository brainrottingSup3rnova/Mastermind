using MastermindLibrary;//I test non eseguono anche se ho aggiunto il riferimento a MastermindLibrary, ho ricreato il progetto piú volte, ma sembra non funzionare.

namespace TestMastermind
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Giocatore giocatore1 = new Giocatore("susususup");
            Bot bot1 = new Bot();
            FixedGenerator fixedGenerator = new FixedGenerator();
            Gioco gioco = new Gioco(giocatore1, fixedGenerator);

            ColoriDellaSequenza[] sequenza =
            {
                ColoriDellaSequenza.ROSSO,
                ColoriDellaSequenza.ROSSO,
                ColoriDellaSequenza.ROSSO,
                ColoriDellaSequenza.ROSSO,
            };

            ColoriDellaSequenza[] sequenza2 =
            {
                ColoriDellaSequenza.NERO,
                ColoriDellaSequenza.NERO,
                ColoriDellaSequenza.NERO,
                ColoriDellaSequenza.NERO,
            };
            Assert.AreEqual(sequenza2, gioco.ControllaTentativo(sequenza));
        }

        [TestMethod]
        public void Gioco_TentativoParzialmenteSbagliato_RitornaSequenzaNeraBianca()
        {
            Giocatore giocatore1 = new Giocatore("susususup");
            Bot bot1 = new Bot();
            FixedGenerator fixedGenerator = new FixedGenerator();
            Gioco gioco = new Gioco(giocatore1, fixedGenerator);

            ColoriDellaSequenza[] sequenza =
            {
                ColoriDellaSequenza.ROSSO,
                ColoriDellaSequenza.BLU,
                ColoriDellaSequenza.ROSSO,
                ColoriDellaSequenza.ROSSO,
            };

            ColoriDellaSequenza[] sequenza2 =
            {
                ColoriDellaSequenza.NERO,
                ColoriDellaSequenza.NULL,
                ColoriDellaSequenza.NERO,
                ColoriDellaSequenza.NERO,
            };
            Assert.AreEqual(sequenza2, gioco.ControllaTentativo(sequenza));
        }

        [TestMethod]
        public void Gioco_TentativoCompletamenteSbagliato_RitornaSequenzaNull()
        {
            Giocatore giocatore1 = new Giocatore("susususup");
            Bot bot1 = new Bot();
            FixedGenerator fixedGenerator = new FixedGenerator();
            Gioco gioco = new Gioco(giocatore1, fixedGenerator);

            ColoriDellaSequenza[] sequenza =
            {
                ColoriDellaSequenza.GIALLO,
                ColoriDellaSequenza.VERDE,
                ColoriDellaSequenza.BLU,
                ColoriDellaSequenza.ROSSO,
            };

            ColoriDellaSequenza[] sequenza2 =
            {
                ColoriDellaSequenza.NULL,
                ColoriDellaSequenza.NULL,
                ColoriDellaSequenza.NULL,
                ColoriDellaSequenza.NULL,
            };
            Assert.AreEqual(sequenza2, gioco.ControllaTentativo(sequenza));
        }

        [TestMethod]
        public void Gioco_TentativoParzialmenteCorretto_RitornaSequenzaNeraNull()
        {
            Giocatore giocatore1 = new Giocatore("susususup");
            Bot bot1 = new Bot();
            FixedGenerator fixedGenerator = new FixedGenerator();
            Gioco gioco = new Gioco(giocatore1, fixedGenerator);

            ColoriDellaSequenza[] sequenza =
            {
                ColoriDellaSequenza.ROSSO,
                ColoriDellaSequenza.ROSSO,
                ColoriDellaSequenza.GIALLO,
                ColoriDellaSequenza.VERDE,
            };

            ColoriDellaSequenza[] sequenza2 =
            {
                ColoriDellaSequenza.NERO,
                ColoriDellaSequenza.NERO,
                ColoriDellaSequenza.NULL,
                ColoriDellaSequenza.NULL,
            };
            Assert.AreEqual(sequenza2, gioco.ControllaTentativo(sequenza));
        }
    }
}