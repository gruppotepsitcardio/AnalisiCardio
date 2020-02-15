using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Datacardio.test
{
    [TestClass]
    public class TestCuore
    {
        [TestMethod]
        public void Cardio1() //senza DataRow
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
        [DataRow(23)]
        [DataRow(71)]
        [DataRow(40)]
        [DataRow(35)]
        [DataRow(50)]
        public void CardioData(int anni)
        {
            int bpm = 197;
            double frequenza = CardioLibrary.calcolicuore.Cardio(23);
            Assert.AreEqual(bpm, frequenza);
            int bpm2 = 149;
            double frequenza2 = CardioLibrary.calcolicuore.Cardio(71);
            Assert.AreEqual(bpm2, frequenza2);
            int bpm3 = 180;
            double frequenza3 = CardioLibrary.calcolicuore.Cardio(40);
            Assert.AreEqual(bpm3, frequenza3);
            int bpm4 = 185;
            double frequenza4 = CardioLibrary.calcolicuore.Cardio(35);
            Assert.AreEqual(bpm4, frequenza4);
            int bpm5 = 170;
            double frequenza5 = CardioLibrary.calcolicuore.Cardio(50);
            Assert.AreEqual(bpm5, frequenza5);

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
        [DataRow(204)]
        [DataRow(190)]
        [DataRow(168)]
        [DataRow(200)]
        [DataRow(134)]
        public void FrequenzaMinimaGymData(int bpm)
        {
            int minima1 = 142;
            double frequenza1 = CardioLibrary.calcolicuore.frequenzaCardiomin(204);
            Assert.AreEqual(minima1, frequenza1);
            int minima2 = 133;
            double frequenza2= CardioLibrary.calcolicuore.frequenzaCardiomin(190);
            Assert.AreEqual(minima2, frequenza2);
            int minima3 = 117;
            double frequenza3 = CardioLibrary.calcolicuore.frequenzaCardiomin(168);
            Assert.AreEqual(minima3, frequenza3);
            int minima4 = 140;
            double frequenza4 = CardioLibrary.calcolicuore.frequenzaCardiomin(200);
            Assert.AreEqual(minima4, frequenza4);
            int minima5 = 93;
            double frequenza5 = CardioLibrary.calcolicuore.frequenzaCardiomin(134);
            Assert.AreEqual(minima5, frequenza5);
            

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
        [DataRow(144)]
        [DataRow(167)]
        [DataRow(124)]
        [DataRow(210)]
        [DataRow(104)]
        public void FrequenzaMassimaGymData(int bpm)
        {
            int massima1 = 129;
            int frequenza1 = CardioLibrary.calcolicuore.frequenzaCardiomax(144);
            Assert.AreEqual(massima1, frequenza1);
            int massima2 = 150;
            int frequenza2 = CardioLibrary.calcolicuore.frequenzaCardiomax(167);
            Assert.AreEqual(massima2, frequenza2);
      
            int massima3 = 111;
            int frequenza3 = CardioLibrary.calcolicuore.frequenzaCardiomax(124);
            Assert.AreEqual(massima3, frequenza3);
      
        
            int massima4 = 189;
            int frequenza4 = CardioLibrary.calcolicuore.frequenzaCardiomax(210);
            Assert.AreEqual(massima4, frequenza4);
      
        
            int massima5 = 93;
            int frequenza5= CardioLibrary.calcolicuore.frequenzaCardiomax(104);
            Assert.AreEqual(massima5, frequenza5);
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
        [DataRow(197)]
        [DataRow(149)]
        [DataRow(180)]
        [DataRow(186)]
        [DataRow(170)]
        public void FrequenzaCardioData(int bpm)
        {
            int frequenzaGinnastica1 = 157;
            double bpm1 = CardioLibrary.calcolicuore.frequenzaCardioGym(197);
            Assert.AreEqual(frequenzaGinnastica1, bpm1);
            
            int frequenzaGinnastica2 = 119;
            double bpm2 = CardioLibrary.calcolicuore.frequenzaCardioGym(149);
            Assert.AreEqual(frequenzaGinnastica2, bpm2);
      
            int frequenzaGinnastica3 = 144;
            double bpm3= CardioLibrary.calcolicuore.frequenzaCardioGym(180);
            Assert.AreEqual(frequenzaGinnastica3, bpm3);
        
            int frequenzaGinnastica4 = 148;
            double bpm4 = CardioLibrary.calcolicuore.frequenzaCardioGym(186);
            Assert.AreEqual(frequenzaGinnastica4, bpm4);

            int frequenzaGinnastica5 = 136;
            double bpm5 = CardioLibrary.calcolicuore.frequenzaCardioGym(170);
            Assert.AreEqual(frequenzaGinnastica5, bpm5);
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
        [DataRow(78,98.5,35,160)]
        [DataRow(68, 87.5, 45, 160)]
        [DataRow(100, 86, 48, 180)]
        [DataRow(55, 102.5, 15, 200)]
        public void CalorieUominiData(double peso, double media, double anni, double esercizio)
        {
            double calorie1= 1133.0114722753347;
            double frequenza1 = CardioLibrary.calcolicuore.ConsumoCalorieUomo(78, 98.5, 35, 160); //peso,frequenza,anni,allenamento;
            Assert.AreEqual(calorie1, frequenza1);

     
            double calorie2 = 805.1716061185465;
            double frequenza2 = CardioLibrary.calcolicuore.ConsumoCalorieDonna(68, 87.5, 45, 110);
            Assert.AreEqual(calorie2, frequenza2);

            double calorie3 = 1471.7065009560226;
            double frequenza3 = CardioLibrary.calcolicuore.ConsumoCalorieDonna(100, 86, 48, 180);
            Assert.AreEqual(calorie3, frequenza3);

      
        
            double calorie4 = 1600.1816443594646;
            double frequenza4 = CardioLibrary.calcolicuore.ConsumoCalorieDonna(55, 102.5, 15, 200);
            Assert.AreEqual(calorie4, frequenza4);


        }


    }
}





