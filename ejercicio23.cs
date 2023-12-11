/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici X.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // CÓDIGO MAIN
        public static void Main()
        {
            const string MsgEnterOption = "Escribe el número de cada opción para calcular el área de dicha figura: ";
            const string MsgOptions = "1. Cuadrado\n2. Rectángulo\n3. Círculo\n4. Pentágono";
            const string MsgUserOption = "Tu elección: ";

            int userElection;

            Console.WriteLine(MsgEnterOption);
            Console.WriteLine(MsgOptions);
            Console.Write(MsgUserOption);

            userElection = Convert.ToInt16(Console.ReadLine());

            switch (userElection)
            {
                case 1:
                    // Método cálculo
                    break;

                case 2:
                    // Método cálculo
                    break;

                case 3:
                    // Método cálculo
                    break;

                case 4:
                    // Método cálculo
                    break;
            }
        }

        // Cuadrado
        public static double AreaCalculator(double side, int elevateToNumber)
        {
            return Math.Pow(side, elevateToNumber);
        }

        // Rectángulo
        public static double AreaCalculator(double side, double height)
        {
            return side * height;
        }

        // Círuclo
        public static double AreaCalculator(double radius, double piNumber, int elevateToNumber)
        {
            return piNumber * Math.Pow(radius, elevateToNumber);
        }

        // Pentágono
        public static double AreaCalculator(double side, double numSides, double apotem, int divideToNumber)
        {
            return ((side * numSides) * apotem) / divideToNumber;
        }
    }
}