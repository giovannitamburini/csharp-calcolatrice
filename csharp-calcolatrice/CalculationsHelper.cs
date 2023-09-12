using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalculationsHelper
    {
        /*
            Esercizio di oggi: csharp-calcolatrice
            repo : csharp-calcolatrice
            Creare una classe di helper CalcoliHelper.
            Come visto a lezione, strutturare la classe in modo che non possa essere istanziata e che presenti i seguenti metodi static:
            - Somma di due numeri interi
            - Somma di due numeri double
            - Differenza tra due numeri interi
            - Differenza tra due numeri double
            - Moltiplicazione di due numeri interi
            - Moltiplicazione di due numeri double
            - Valore assoluto di un numero intero
            - Valore assoluto di un numero double
            - Minimo tra due numeri interi
            - Minimo tra due numeri double
            - Massimo tra due numeri interi
            - Massimo tra due numeri double
            Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto...Quale?
            Scrivetelo in un commento all’interno del codice! :faccia_nerd: Testate tutti i metodi della vostra classe di helper (con un esempio per ogni casistica).
             */

        // funzione che somma due numeri interi
        public static int CalculateSumOfTwoInt(int num1, int num2)
        {
            return num1 + num2;
        }

        // funzione che somma due numeri double
        public static double CalculateSumOfTwoDouble(double num1, double num2)
        {
            return num1 + num2;
        }

        // funzione che fa la sottrazione tra due interi
        public static int CalculateDifferenceOfTwoInt(int num1, int num2)
        {
            return num1 - num2;
        }

        // funzione che fa la differenza tra due double
        public static double CalculateDifferenceOfTwoDouble(double num1, double num2)
        {
            return num1 - num2;
        }

        // funzione per moltiplicare tra loro due interi
        public static int CalculateProductBetweenIntegers(int num1, int num2)
        {
            return num1 * num2;
        }

        // funzione per moltiplicare tra loro due double
        public static double CalculateProductBetweenDoubles(double num1, double num2)
        {
            return num1 * num2;
        }

        // funzione per calcolare il valore assoluto di un intero
        public static int CalculateIntAbsoluteValue(int num)
        {
            return Math.Abs(num);
        }

        // funzione per calcolare il valore assoluto di un double
        public static double CalculateDoubleAbsoluteValue(double num)
        {
            return Math.Abs(num);
        }

        // funzione per controllare il minimo tra due int
        public static int CheckMinBetweenTwoInt(int num1, int num2)
        {
            return Math.Min(num1, num2);
        }

        // funzione per controllare il minimo tra due double
        public static double CheckMinBetweenTwoDouble(double num1, double num2)
        {
            return Math.Min(num1, num2);
        }

        // funzione per controllare il massimo tra due int
        public static int CheckMaxBetweenTwoInt(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }

        // funzione per controllare il massimo tra due double
        public static double CheckMaxBetweenTwoDouble(double num1, double num2)
        {
            return Math.Max(num1, num2);
        }
    }
}
