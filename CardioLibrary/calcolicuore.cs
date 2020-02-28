using System;

namespace CardioLibrary
{
    public class calcolicuore
    {
        public static int Cardio(int anni) //punto1
        {
            if (anni <= 75)
            {
                int bpm = 220 - anni;
                return bpm;

            }
            else
            {
                int bpm = 220 - anni;
                return bpm;

            }
        }
        public static int frequenzaCardiomax(int bpm) //punto1.2
        {
            int max = (90 * bpm / 100);
            return max;
        }
        public static int frequenzaCardiomin(int bpm) //punto1.2
        {

            int min = (70 * bpm / 100);
            return min;
        }
        public static int frequenzaCardioGym(int bpm) //punto1.3
        {
            int frequenza = ((70 * bpm / 100)+ (90 * bpm / 100));
            int mediaGym = frequenza/ 2;
            return mediaGym;
        }
        public static double frequenzaCardio(double bpm) //punto3
        {
            
            double media = bpm / 2;
            return media;
        }
        public static double ConsumoCalorieUomo(double peso, double media, double anni, double esercizio) //punto3
        {
            double Calorie = (anni * 0.2017) + (peso * 0.199) + (media * 0.6309) - 55.0969;
            double calorie_bruciate = Calorie * esercizio / 4.184;
            return calorie_bruciate;

        }
        public static double ConsumoCalorieDonna(double peso, double media, double anni, double esercizio) //punto3
        {
            double Calorie = (anni * 0.074) + (peso * 0.126) + (media * 0.4472) - 20.4022;
            double calorie_bruciate = Calorie * esercizio / 4.184;
            return calorie_bruciate;
        }
       public static string Battito(int battito)
        {
            if (battito < 60)
            {
                return "bradicardico";
            }
            else if (battito > 60 && battito<=100)
            {
                return "normale";
            }
            else
            {
                return  "tachicardico";
            }
       }
        public static double spesa_energetica_corsa(double km, double kg)
        {
            double corsa = 0.9 * km * kg;
            return corsa;
          
        }
        public static double spesa_energetica_camminata(double km, double kg)
        {
            double camminata = 0.50 * km * kg;
            return camminata;

        }

    }
}
