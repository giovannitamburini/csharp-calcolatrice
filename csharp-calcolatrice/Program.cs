namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
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
            int IntNum1 = 5;
            int IntNum2 = 9;

            int IntNum3 = -5;

            double DoubleNum1 = 3.5d;
            double DoubleNum2 = 8.3d;

            double DoubleNum3 = -7.8d;

            // controllo le funzioni per la somma
            int IntSum = CalculationsHelper.CalculateSumOfTwoNum(IntNum1, IntNum2);
            Console.WriteLine($"La somma tra {IntNum1} e {IntNum2} é: {IntSum}");

            double DoubleSum = CalculationsHelper.CalculateSumOfTwoNum(DoubleNum1, DoubleNum2);
            Console.WriteLine($"La somma tra {DoubleNum1} e {DoubleNum2} é: {DoubleSum}");

            // controllo le funzioni per la differenza
            int IntDiff = CalculationsHelper.CalculateDifferenceOfTwoNum(IntNum1, IntNum2);
            Console.WriteLine($"La diffrenza tra {IntNum1} e {IntNum2} é: {IntDiff}");

            double DoubleDiff = CalculationsHelper.CalculateDifferenceOfTwoNum(DoubleNum1, DoubleNum2);
            Console.WriteLine($"La differenza tra {DoubleNum1} e {DoubleNum2} é: {DoubleDiff}");

            // controllo le funzioni per la moltiplicazione
            int IntProduct = CalculationsHelper.CalculateProductBetweenTwoNum(IntNum1, IntNum2);
            Console.WriteLine($"Il prodotto tra {IntNum1} e {IntNum2} é: {IntProduct}");

            double DoubleProduct = CalculationsHelper.CalculateProductBetweenTwoNum(DoubleNum1, DoubleNum2);
            Console.WriteLine($"Il prodotto tra {DoubleNum1} e {DoubleNum2} è: {DoubleProduct}");

            // controllo le funzioni per i valori assoluti
            int IntAbsoluteValue = CalculationsHelper.CalculateAbsoluteValue(IntNum3);
            Console.WriteLine($"Il valore assoluto di {IntNum3} è: {IntAbsoluteValue}");

            double DoubleAbsoluteValue = CalculationsHelper.CalculateAbsoluteValue(DoubleNum3);
            Console.WriteLine($"Il valore assoluto di {DoubleNum3} è: {DoubleAbsoluteValue}");

            // controllo le funzioni per il valore minimo
            int IntMin = CalculationsHelper.CheckMinBetweenTwoNum(IntNum1, IntNum2);
            Console.WriteLine($"Il minimo tra {IntNum1} e {IntNum2} è: {IntMin}");

            double DoubleMin = CalculationsHelper.CheckMinBetweenTwoNum(DoubleNum1, DoubleNum2);
            Console.WriteLine($"Il minimo tra {DoubleNum1} e {DoubleNum2} è: {DoubleMin}");

            // controllo le funzioni per il valore massimo
            int IntMax = CalculationsHelper.CheckMaxBetweenTwoNum(IntNum1, IntNum2);
            Console.WriteLine($"Il massimo tra {IntNum1} e {IntNum2} è: {IntMax}");

            double DoubleMax = CalculationsHelper.CheckMaxBetweenTwoNum(DoubleNum1, DoubleNum2);
            Console.WriteLine($"Il massimo tra {DoubleNum1} e {DoubleNum2} è: {DoubleMax}");

            // RISPOSTA ALLA DOMANDA: "Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto...Quale?"
            // Applica nella pratica il principio del POLIMORFISMO, detto anche il terzo pilastro della programmazione orientata agli oggetti.
            // Nel nostro caso specifico il polimorfismo viene applicato tramite l' "overloading" e permette l'utilizzo dello stesso metodo coerentemente ma per eseguire le operazioni su tipi di dato diversi.
            // Grazie al polimorfismo il compilatore seleziona in automatico il giusto metodo

            // bonus
            double ExponentialNum = CalculationsHelper.CalculateExponentiation(IntNum1, IntNum3);
            Console.WriteLine($"L'esponenziale di {IntNum1} con esponente {IntNum3} è: {ExponentialNum}");
        }
    }
}