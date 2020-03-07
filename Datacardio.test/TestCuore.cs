using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Datacardio.test
{
    [TestClass]
    public class TestCuore
    {
        [TestMethod]
        public void Cardio1() //punto 1 calcolo bpm massimo
        {
            int bpm = 197;
            double frequenza = CardioLibrary.calcolicuore.Cardio(23);
            Assert.AreEqual(bpm, frequenza);

        }
        [TestMethod]
        public void Cardio2() //punto 1 calcolo bpm massimo
        {

            int bpm = 149;
            double frequenza = CardioLibrary.calcolicuore.Cardio(71);
            Assert.AreEqual(bpm, frequenza);
        }
        [TestMethod]
        public void Cardio3() //punto 1 calcolo bpm massimo
        {
            int bpm = 180;
            double frequenza = CardioLibrary.calcolicuore.Cardio(40);
            Assert.AreEqual(bpm, frequenza);
        }
        [TestMethod]
        public void Cardio4() //punto 1 calcolo bpm massimo
        {
            int bpm = 185;
            double frequenza = CardioLibrary.calcolicuore.Cardio(35);
            Assert.AreEqual(bpm, frequenza);

        }
        [TestMethod]
        public void Cardio5() //punto 1 calcolo bpm massimo
        {
            int bpm = 170;
            double frequenza = CardioLibrary.calcolicuore.Cardio(50);
            Assert.AreEqual(bpm, frequenza);
        }
        [DataTestMethod] //punto 1 calcolo bpm massimo effettuato con il datarow
        [DataRow(23,197)]
        [DataRow(71,149)]
        [DataRow(40,180)]
        [DataRow(35,185)]
        [DataRow(50,170)]
        public void CardioData(int anni,int bpm)
        {
           
            double frequenza = CardioLibrary.calcolicuore.Cardio(anni);
            Assert.AreEqual(bpm, frequenza);
           
            double frequenza2 = CardioLibrary.calcolicuore.Cardio(anni);
            Assert.AreEqual(bpm, frequenza2);
           
            double frequenza3 = CardioLibrary.calcolicuore.Cardio(anni);
            Assert.AreEqual(bpm, frequenza3);
          
            double frequenza4 = CardioLibrary.calcolicuore.Cardio(anni);
            Assert.AreEqual(bpm, frequenza4);
          
            double frequenza5 = CardioLibrary.calcolicuore.Cardio(anni);
            Assert.AreEqual(bpm, frequenza5);

        }
        [TestMethod]
        public void FrequenzaMinimaGym1() //punto 1.2 calcolo bpm efficaci per un allenamento
        {
            int minima = 93;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomin(134);
            Assert.AreEqual(minima, frequenza);
        }

        [TestMethod]
        public void FrequenzaMinimaGym2() //punto 1.2 calcolo bpm efficaci per un allenamento
        {
            int minima = 140;
            int frequenza = CardioLibrary.calcolicuore.frequenzaCardiomin(200);
            Assert.AreEqual(minima, frequenza);

        }
        [TestMethod]
        public void FrequenzaMinimaGym3() //punto 1.2 calcolo bpm efficaci per un allenamento
        {
            int minima = 117;
            double frequenza = CardioLibrary.calcolicuore.frequenzaCardiomin(168);
            Assert.AreEqual(minima, frequenza);

        }
        [TestMethod]
        public void FrequenzaMinimaGym4() //punto 1.2 calcolo bpm efficaci per un allenamento
        {
            int minima = 133;
            double frequenza = CardioLibrary.calcolicuore.frequenzaCardiomin(190);
            Assert.AreEqual(minima, frequenza);

        }
        [TestMethod]
        public void FrequenzaMinimaGym5() //punto 1.2 calcolo bpm efficaci per un allenamento
        {
            int minima = 142;
            double frequenza = CardioLibrary.calcolicuore.frequenzaCardiomin(204);
            Assert.AreEqual(minima, frequenza);

        }
        [DataTestMethod] //punto 1.2 calcolo bpm efficaci minimi per un allenamento,con datarow
        [DataRow(204,142)]
        [DataRow(190,133)]
        [DataRow(168,117)]
        [DataRow(200,140)]
        [DataRow(134,93)]
        public void FrequenzaMinimaGymData(int bpm,int aspettata)
        {
           
            double frequenza1 = CardioLibrary.calcolicuore.frequenzaCardiomin(bpm);
            Assert.AreEqual(aspettata, frequenza1);
            double frequenza2 = CardioLibrary.calcolicuore.frequenzaCardiomin(bpm);
            Assert.AreEqual(aspettata, frequenza2);
            double frequenza3 = CardioLibrary.calcolicuore.frequenzaCardiomin(bpm);
            Assert.AreEqual(aspettata, frequenza3);
            double frequenza4 = CardioLibrary.calcolicuore.frequenzaCardiomin(bpm);
            Assert.AreEqual(aspettata, frequenza4);
            double frequenza5 = CardioLibrary.calcolicuore.frequenzaCardiomin(bpm);
            Assert.AreEqual(aspettata, frequenza5);


        }

        [TestMethod]
        public void FrequenzaMassimaGym1() //punto 1.2 calcolo bpm efficaci massimi per un allenamento
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
        [TestMethod] //punto 1.2 calcolo bpm efficaci massimi per un allenamento,con datarow
        [DataRow(144,129)]
        [DataRow(167,150)]
        [DataRow(124,111)]
        [DataRow(210,189)]
        [DataRow(104,93)]
        public void FrequenzaMassimaGymData(int bpm,int massima)
        {
           
            int frequenza1 = CardioLibrary.calcolicuore.frequenzaCardiomax(bpm);
            Assert.AreEqual(massima, frequenza1);
           
            int frequenza2 = CardioLibrary.calcolicuore.frequenzaCardiomax(bpm);
            Assert.AreEqual(massima, frequenza2);

        
            int frequenza3 = CardioLibrary.calcolicuore.frequenzaCardiomax(bpm);
            Assert.AreEqual(massima, frequenza3);


   
            int frequenza4 = CardioLibrary.calcolicuore.frequenzaCardiomax(bpm);
            Assert.AreEqual(massima, frequenza4);


   
            int frequenza5 = CardioLibrary.calcolicuore.frequenzaCardiomax(bpm);
            Assert.AreEqual(massima, frequenza5);
        }



        [TestMethod] //punto 1.2 calcolo bpm efficaci per un allenamento
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

        [DataTestMethod] //punto 1.2 calcolo bpm efficaci per un allenamento,con datarow
        [DataRow(197,157)]
        [DataRow(149,119)]
        [DataRow(180,144)]
        [DataRow(186, 148)]
        [DataRow(170,136)]
        public void FrequenzaCardioData(int bpm, int frequenzaGinnastica)
        {
           
            double bpm1 = CardioLibrary.calcolicuore.frequenzaCardioGym(bpm);
            Assert.AreEqual(frequenzaGinnastica, bpm1);

           
            double bpm2 = CardioLibrary.calcolicuore.frequenzaCardioGym(bpm);
            Assert.AreEqual(frequenzaGinnastica, bpm2);

           
            double bpm3 = CardioLibrary.calcolicuore.frequenzaCardioGym(bpm);
            Assert.AreEqual(frequenzaGinnastica, bpm3);

           
            double bpm4 = CardioLibrary.calcolicuore.frequenzaCardioGym(bpm);
            Assert.AreEqual(frequenzaGinnastica, bpm4);

         
            double bpm5 = CardioLibrary.calcolicuore.frequenzaCardioGym(bpm);
            Assert.AreEqual(frequenzaGinnastica, bpm5);
        }
        [TestMethod] //punto2
        public void BpmMinututo1()
        {
            string risultato = "normale";
            string battito = CardioLibrary.calcolicuore.Battito(100);
            Assert.AreEqual(risultato, battito);

        }
        [TestMethod]
        public void BpmMinututo2()
        {
            string risultato = "tachicardico";
            string battito = CardioLibrary.calcolicuore.Battito(110);
            Assert.AreEqual(risultato, battito);

        }
        [TestMethod]
        public void BpmMinututo3()
        {
            string risultato = "normale";
            string battito = CardioLibrary.calcolicuore.Battito(100);
            Assert.AreEqual(risultato, battito);

        }
        [TestMethod]
        public void BpmMinututo4()
        {
            string risultato = "bradicardico";
            string battito = CardioLibrary.calcolicuore.Battito(50);
            Assert.AreEqual(risultato, battito);

        }
        [TestMethod]
        public void BpmMinututo5()
        {
            string risultato = "normale";
            string battito = CardioLibrary.calcolicuore.Battito(100);
            Assert.AreEqual(risultato, battito);

        }
        [DataTestMethod] //punto2
        [DataRow(160, "tachicardico")]
        [DataRow(68, "normale")]
        [DataRow(100, "normale")]
        [DataRow(102, "tachicardico")]
        public void BpmMinutiData(int battiti, string risultato)
        {

            string battito = CardioLibrary.calcolicuore.Battito(battiti);
            Assert.AreEqual(risultato, battito);


            string battito1 = CardioLibrary.calcolicuore.Battito(battiti);
            Assert.AreEqual(risultato, battito1);


            string battito2 = CardioLibrary.calcolicuore.Battito(battiti);
            Assert.AreEqual(risultato, battito2);


            string battito3 = CardioLibrary.calcolicuore.Battito(battiti);
            Assert.AreEqual(risultato, battito3);


        }
        [TestMethod] //punto3 calcolo calorie uomo/donna
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
        [DataTestMethod]
        [DataRow(78, 98.5, 35, 160, 1133.0114722753347)]
        [DataRow(68, 87.5, 45, 160, 868.655831739962)]
        [DataRow(100, 86, 48, 180, 1236.5148183556405)]
        [DataRow(55, 102.5, 15, 200, 1125.279636711281)]
        public void CalorieData(double peso, double bpm, double anni, double esercizio,double calorie)
        {
           
            double frequenza1 = CardioLibrary.calcolicuore.ConsumoCalorieUomo(peso,bpm,anni,esercizio); //peso,frequenza,anni,allenamento;
            Assert.AreEqual(calorie, frequenza1);


            
            double frequenza2 = CardioLibrary.calcolicuore.ConsumoCalorieDonna(peso, bpm, anni, esercizio);
            Assert.AreEqual(calorie, frequenza2);

      
            double frequenza3 = CardioLibrary.calcolicuore.ConsumoCalorieUomo(peso, bpm, anni, esercizio);
            Assert.AreEqual(calorie, frequenza3);



           
            double frequenza4 = CardioLibrary.calcolicuore.ConsumoCalorieDonna(peso, bpm, anni, esercizio);
            Assert.AreEqual(calorie, frequenza4);


        }
        
        [TestMethod] //spesa energetica corsa
        public void corsa1()
        {
            double risultato = 62.1;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_corsa(1,69);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [TestMethod]
        public void corsa2()
        {
            double risultato = 160.704;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_corsa(2.88, 62);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [TestMethod]
        public void corsa3()
        {
            double risultato = 225;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_corsa(5, 50);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [TestMethod]
        public void corsa4()
        {
            double risultato = 17521.2;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_corsa(314, 62);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [TestMethod]
        public void corsa5()
        {
            double risultato = 252;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_corsa(3.5, 80);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [DataTestMethod] //spesa energetica corsa con datarow
        [DataRow(20, 67,1206)]
        [DataRow(310, 45,12555)]
        [DataRow(16, 88,1267.2)]
        [DataRow(2, 70,126)]
        [DataRow(4.5,90,364.5)]
        public void Spesa_enerigetica_CorsaData(double km, double kg,double aspettata)
        {

            double spesa_emnergetica1= CardioLibrary.calcolicuore.spesa_energetica_corsa(km,kg);
            Assert.AreEqual(aspettata, spesa_emnergetica1);
            double spesa_emnergetica2 = CardioLibrary.calcolicuore.spesa_energetica_corsa(km,kg);
            Assert.AreEqual(aspettata, spesa_emnergetica2);
            double spesa_emnergetica3 = CardioLibrary.calcolicuore.spesa_energetica_corsa(km, kg);
            Assert.AreEqual(aspettata, spesa_emnergetica3);
            double spesa_emnergetica4 = CardioLibrary.calcolicuore.spesa_energetica_corsa(km,kg);
            Assert.AreEqual(aspettata, spesa_emnergetica4);
            double spesa_emnergetica5 = CardioLibrary.calcolicuore.spesa_energetica_corsa(km,kg);
            Assert.AreEqual(aspettata, spesa_emnergetica5);


        }
        [TestMethod] //spesa energetica camminata
        public void camminata1()
        {
            double risultato = 164;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_camminata(4, 82);
            Assert.AreEqual(risultato, spesa_energetica);

        }

        public void camminata2()
        {
            double risultato = 90;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_camminata(2, 90);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [TestMethod]
        public void camminata3()
        {
            double risultato = 33.75;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_camminata(1.5, 45);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [TestMethod]
        public void camminata4()
        {
            double risultato = 240;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_camminata(8, 60);
            Assert.AreEqual(risultato, spesa_energetica);

        }
        [TestMethod]
        public void camminata5()
        {
            double risultato = 350;
            double spesa_energetica = CardioLibrary.calcolicuore.spesa_energetica_camminata(10, 70);
            Assert.AreEqual(risultato, spesa_energetica);


        }
        [DataTestMethod] //spesa energetica camminata con datarow
        [DataRow(20, 67, 670)]
        [DataRow(3, 45, 67.5)]
        [DataRow(6, 90, 270)]
        [DataRow(8, 70, 280)]
        [DataRow(9, 50, 225)]
        public void Spesa_enerigetica_CamminataData(double km, double kg, double aspettata)
        {

            double spesa_emnergetica1 = CardioLibrary.calcolicuore.spesa_energetica_camminata(km, kg);
            Assert.AreEqual(aspettata, spesa_emnergetica1);
            double spesa_emnergetica2 = CardioLibrary.calcolicuore.spesa_energetica_camminata(km, kg);
            Assert.AreEqual(aspettata, spesa_emnergetica2);
            double spesa_emnergetica3 = CardioLibrary.calcolicuore.spesa_energetica_camminata(km, kg);
            Assert.AreEqual(aspettata, spesa_emnergetica3);
            double spesa_emnergetica4 = CardioLibrary.calcolicuore.spesa_energetica_camminata(km, kg);
            Assert.AreEqual(aspettata, spesa_emnergetica4);
            double spesa_emnergetica5 = CardioLibrary.calcolicuore.spesa_energetica_camminata(km, kg);
            Assert.AreEqual(aspettata, spesa_emnergetica5);





        }



    }
}





