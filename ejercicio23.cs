/*
* Author: Miroslav Magerov
* M03. Programaci� UF2
* v1. dd/mm/aa
* Exercici X.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // C�DIGO MAIN
        public static void Main()
        {
            const string MsgEnterOption = "Escribe el n�mero de cada opci�n para calcular el �rea de dicha figura: ";
            const string MsgOptions = "1. Cuadrado\n2. Rect�ngulo\n3. C�rculo\n4. Pent�gono";
            const string MsgUserOption = "Tu elecci�n: ";

            int userElection;

            Console.WriteLine(MsgEnterOption);
            Console.WriteLine(MsgOptions);
            Console.Write(MsgUserOption);

            userElection = Convert.ToInt16(Console.ReadLine());

            switch (userElection)
            {
                case 1:
                    // M�todo c�lculo
                    break;

                case 2:
                    // M�todo c�lculo
                    break;

                case 3:
                    // M�todo c�lculo
                    break;

                case 4:
                    // M�todo c�lculo
                    break;
            }
        }

        // Cuadrado
        public static double AreaCalculator(double side, int elevateToNumber)
        {
            return Math.Pow(side, elevateToNumber);
        }

        // Rect�ngulo
        public static double AreaCalculator(double side, double height)
        {
            return side * height;
        }

        // C�ruclo
        public static double AreaCalculator(double radius, double piNumber, int elevateToNumber)
        {
            return piNumber * Math.Pow(radius, elevateToNumber);
        }

        // Pent�gono
        public static double AreaCalculator(double side, double numSides, double apotem, int divideToNumber)
        {
            return ((side * numSides) * apotem) / divideToNumber;
        }
    }
}