﻿using System;


namespace CardioLibrary
{
    public class calcolicuore
    {
                //////////////////////////////////////////////////////////////esercizio1//////////////////////////////////////////////////////////////////////////////////////
        public static int Cardio(int anni) 
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
        public static int frequenzaCardiomax(int bpm)
        {
            int max = (90 * bpm / 100);
            return max;
        }
        public static int frequenzaCardiomin(int bpm) 
        {

            int min = (70 * bpm / 100);
            return min;
        }
        public static int frequenzaCardioGym(int bpm) 
        {
            int frequenza = ((70 * bpm / 100)+ (90 * bpm / 100));
            int mediaGym = frequenza/ 2;
            return mediaGym;
        }
        //////////////////////////////////////////////////////////////esercizio2//////////////////////////////////////////////////////////////////////////////////////
        public static string Battito(int battito) 
        {
            if (battito < 60)
            {
                return "bradicardico";
            }
            else if (battito > 60 && battito <= 100)
            {
                return "normale";
            }
            else
            {
                return "tachicardico";
            }
        }
        //////////////////////////////////////////////////////////////esercizio3//////////////////////////////////////////////////////////////////////////////////////
        public static double frequenzaCardio(double bpm)
        {
            
            double mediabpm = bpm / 2;
            return mediabpm;
        }
        public static double ConsumoCalorieUomo(double peso, double media, double anni, double esercizio) 
        {
            double Calorie = (anni * 0.2017) + (peso * 0.199) + (media * 0.6309) - 55.0969; 
            double calorie_bruciate = Calorie * esercizio / 4.184; 
            return calorie_bruciate;

        }
        public static double ConsumoCalorieDonna(double peso, double media, double anni, double esercizio) 
        {
            double Calorie = (anni * 0.074) + (peso * 0.126) + (media * 0.4472) - 20.4022;
            double calorie_bruciate = Calorie * esercizio / 4.184;
            return calorie_bruciate;
        }

        //////////////////////////////////////////////////////////////esercizio4/////////////////////////////////////////////////////////////////////////////////////
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

        //////////////////////////////////////////////////////////////esercizio5///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int Media_bpm(int bpm1, int bpm2, int bpm3, int bpm4, int bpm5, int bpm6, int bpm7, int bpm8, int bpm9, int bpm10, int bpm11,int bpm12,int bpm13,int bpm14,int bpm15,int bpm16,int bpm17,int bpm18,int bpm19,int bpm20,int bpm21,int bpm22, int bpm23, int bpm24)// media giornaliera
        {
            int calcolo = bpm1  + bpm2  + bpm3 + bpm4 + bpm5 + bpm6 + bpm7 + bpm8 + bpm9 + bpm10 + bpm11 + bpm12 + bpm13 + bpm14 + bpm15 + bpm16 + bpm17 + bpm18 + bpm19 + bpm20 + bpm21 + bpm22 + bpm23 + bpm24;
            int media = calcolo / 24;
            return media;
        }
        public static int Riposo_bpm(int bpm1, int bpm2, int bpm3, int bpm4, int bpm5, int bpm6, int bpm7)// battiti di 7 giorni per trovare la media dei battiti a riposo
        {
            int calcoloriposo = bpm1 + bpm2 + bpm3 + bpm4 + bpm5 + bpm6 + bpm7;
            int riposo = calcoloriposo / 7;
            return riposo;

        }
        public static double Variabilità_bpm(int bpm)// e la variabilità tra un battito e l'altro in  millesecondi
        {
            double Variabilità = bpm  * 60 / 1000;
            return Variabilità;
        }



    }
}
