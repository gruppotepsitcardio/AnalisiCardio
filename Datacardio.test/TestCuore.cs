using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Datacardio.test
{
    [TestClass]
    public class TestCuore
    {
        [TestMethod]
        public void Cardio1()
        {
            int bpm = 197;
            double frequenza = CardioLibrary.calcolicuore.Cardio(23);
            Assert.AreEqual(bpm, frequenza);

        }
        [TestMethod]
        public void Cardio2()
        {

            int bpm = 149;
            double frequenza = CardioLibrary.calcolicuore.Cardio(71);
            Assert.AreEqual(bpm, frequenza);
        }
        [TestMethod]
        public void Cardio3()
        {
            int bpm = 180;
            double frequenza = CardioLibrary.calcolicuore.Cardio(40);
            Assert.AreEqual(bpm, frequenza);
        }
        [TestMethod]
        public void Cardio4()
        {
            int bpm = 185;
            double frequenza = CardioLibrary.calcolicuore.Cardio(35);
            Assert.AreEqual(bpm, frequenza);

        }
        [TestMethod]
        public void Cardio5()
        {
            int bpm = 170;
            double frequenza = CardioLibrary.calcolicuore.Cardio(50);
            Assert.AreEqual(bpm, frequenza);
        }
        [TestMethod]
        public void FrequenzaMinimaGym1()
        {
            int minima = 93;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomin(134);
            Assert.AreEqual(minima, frequenza);
        }

        [TestMethod]
        public void FrequenzaMinimaGym2()
        {
            int minima = 140;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomin(200);
            Assert.AreEqual(minima, frequenza);

        }
        [TestMethod]
        public void FrequenzaMinimaGym3()
        {
            int minima = 117;
            double frequenza = CardioLibrary.calcolicuore.frequenzaCardiomin(168);
            Assert.AreEqual(minima, frequenza);

        }
        [TestMethod]
        public void FrequenzaMinimaGym4()
        {
            int minima = 133;
            double frequenza = CardioLibrary.calcolicuore.frequenzaCardiomin(190);
            Assert.AreEqual(minima, frequenza);

        }
        [TestMethod]
        public void FrequenzaMinimaGym5()
        {
            int minima = 142;
            double frequenza = CardioLibrary.calcolicuore.frequenzaCardiomin(204);
            Assert.AreEqual(minima, frequenza);

        }
        [TestMethod]
        public void FrequenzaMassimaGym1()
        {
            int massima = 129;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomax(144);
            Assert.AreEqual(massima, frequenza);
        }
        [TestMethod]
        public void FrequenzaMassimaGym2()
        {
            int massima = 150;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomax(167);
            Assert.AreEqual(massima, frequenza);
        }
        [TestMethod]
        public void FrequenzaMassimaGym3()
        {
            int massima = 111;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomax(124);
            Assert.AreEqual(massima, frequenza);
        }
        [TestMethod]
        public void FrequenzaMassimaGym4()
        {
            int massima = 189;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomax(210);
            Assert.AreEqual(massima, frequenza);
        }
        [TestMethod]
        public void FrequenzaMassimaGym5()
        {
            int massima = 93;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomax(104);
            Assert.AreEqual(massima, frequenza);
        }



        [TestMethod]
        public void FrequenzaCardio1()
        {
            int frequenzaGinnastica = 157;
            double bpm = CardioLibrary.calcolicuore.frequenzaCardioGym(197);
            Assert.AreEqual(frequenzaGinnastica, bpm);

        }
        [TestMethod]
        public void FrequenzaCardio2()
        {
            int frequenzaGinnastica = 119;
            double bpm = CardioLibrary.calcolicuore.frequenzaCardioGym(149);
            Assert.AreEqual(frequenzaGinnastica, bpm);

        }
        [TestMethod]
        public void FrequenzaCardio3()
        {
            int frequenzaGinnastica = 144;
            double bpm = CardioLibrary.calcolicuore.frequenzaCardioGym(180);
            Assert.AreEqual(frequenzaGinnastica, bpm);

        }
        [TestMethod]
        public void FrequenzaCardio4()
        {
            int frequenzaGinnastica = 148;
            double bpm = CardioLibrary.calcolicuore.frequenzaCardioGym(186);
            Assert.AreEqual(frequenzaGinnastica, bpm);

        }
        [TestMethod]
        public void FrequenzaCardio5()
        {
            int frequenzaGinnastica = 136;
            double bpm = CardioLibrary.calcolicuore.frequenzaCardioGym(170);
            Assert.AreEqual(frequenzaGinnastica, bpm);
        }

        [TestMethod]
        public void CalorieUomini1()
        {
            double calorie = 1133.0114722753347;
            double frequenza = CardioLibrary.calcolicuore.ConsumoCalorieUomo(78, 98.5, 35, 160); //peso,frequenza,anni,allenamento;
            Assert.AreEqual(calorie, frequenza);

        }
        [TestMethod]
        public void CalorieDonna1()
        {
            double calorie = 805.1716061185465;
            double frequenza = CardioLibrary.calcolicuore.ConsumoCalorieDonna(68, 87.5, 45, 110);
            Assert.AreEqual(calorie, frequenza);

        }
        [TestMethod]
        public void CalorieUomini2()
        {
            double calorie = 1471.7065009560226;
            double frequenza = CardioLibrary.calcolicuore.ConsumoCalorieDonna(100, 86, 48, 180);
            Assert.AreEqual(calorie, frequenza);

        }
        [TestMethod]
        public void CalorieDonna2()
        {
            double calorie = 1600.1816443594646;
            double frequenza = CardioLibrary.calcolicuore.ConsumoCalorieDonna(55, 102.5, 15, 200);
            Assert.AreEqual(calorie, frequenza);

        }
        [TestMethod]
        public void MediaGiornalieraBattitiCardiacitest()
        {
            double bpm = 197;
            double totbpmensili = 1440;
            double mediavaloreaaspettato = 1,136805555555556;
            double media = CardioLibrary.calcolicuore.MediaGiornalieraBattitiCardiaci(bpm + totbpmensili / totbpmensili);
            Assert.AreEqual(media, mediavaloreaaspettato);

        }

    }
}





