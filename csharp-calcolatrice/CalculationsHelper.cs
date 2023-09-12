using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalculationsHelper
    {
        // funzione che somma due numeri interi
        public static int CalculateSumOfTwoNum(int num1, int num2)
        {
            return num1 + num2;
        }

        // funzione che somma due numeri double
        public static double CalculateSumOfTwoNum(double num1, double num2)
        {
            return Math.Round(num1 + num2, 2);
        }

        // funzione che fa la sottrazione tra due interi
        public static int CalculateDifferenceOfTwoNum(int num1, int num2)
        {
            return num1 - num2;
        }

        // funzione che fa la differenza tra due double
        public static double CalculateDifferenceOfTwoNum(double num1, double num2)
        {
            return Math.Round(num1 - num2, 2);
        }

        // funzione per moltiplicare tra loro due interi
        public static int CalculateProductBetweenTwoNum(int num1, int num2)
        {
            return num1 * num2;
        }

        // funzione per moltiplicare tra loro due double
        public static double CalculateProductBetweenTwoNum(double num1, double num2)
        {
            return Math.Round(num1 * num2, 2);
        }

        // funzione per calcolare il valore assoluto di un intero
        public static int CalculateAbsoluteValue(int num)
        {
            //return Math.Abs(num);

            if (num >= 0)
            {
                return num;

            }
            else
            {
                return num * -1;
            }
        }

        // funzione per calcolare il valore assoluto di un double
        public static double CalculateAbsoluteValue(double num)
        {
            if (num >= 0)
            {
                return num;
            }
            else
            {
                return num * -1;
            }
        }

        // funzione per controllare il minimo tra due int
        public static int CheckMinBetweenTwoNum(int num1, int num2)
        {
            //return Math.Min(num1, num2);

            if(num1 <= num2)
            {
                return num1;

            }
            else
            {
                return num2;
            }
        }

        // funzione per controllare il minimo tra due double
        public static double CheckMinBetweenTwoNum(double num1, double num2)
        {
            //return Math.Min(num1, num2);

            if (num1 <= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        // funzione per controllare il massimo tra due int
        public static int CheckMaxBetweenTwoNum(int num1, int num2)
        {
            //return Math.Max(num1, num2);

            if (num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        // funzione per controllare il massimo tra due double
        public static double CheckMaxBetweenTwoNum(double num1, double num2)
        {
            //return Math.Max(num1, num2);

            if (num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        // BONUS
        // Aggiungete il metodo per l’elevamento a potenza che prende come parametri due numeri interi (base ed esponente) e ritorna la base elevata all’esponente.
        // Occhio che sia la base che l’esponente potrebbero essere uguali a zero oppure numeri negativi! (caso esponente = 0 e base = 0 anche se in matematica sarebbe un numero indefinito usiamo l’approccio informatico che lo calcola come 1)

        public static double CalculateExponentiation(int numBase, int exponent)
        {
            // controllo che numBase non sia uguale a 0
            if (numBase == 0)
            {
                numBase = 1;
            }

            double Exponential = numBase;

            // controllo che l'esponente non sia uguale a 0
            if (exponent == 0)
            {
                exponent = 1;

                return Exponential;

            } else if (exponent < 0)
            {
                exponent *= -1;

                for (int i = 0; i < exponent - 1; i++)
                {
                    Exponential *= numBase;
                }

                return 1 / Exponential;

            } else
            {
                for (int i = 0; i < exponent - 1; i++)
                {
                    Exponential *= numBase;
                }

                return Exponential;
            }
        }
    }
}
