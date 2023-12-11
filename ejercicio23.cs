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
            const string MsgSide = "Introduce el lado de la figura: ";
            const string MsgHeight = "Introduce la altura de la figura: ";
            const string MsgRadius = "Introduce el radio del c�rculo: ";
            const string MsgApotem = "Introduce la apotema del pent�gono: ";

            const int elevateNumber = 2, divideNumber = 2, numberOfPentagonSides = 5;

            int userElection;

            double side, height, radius, piNumber = Math.PI, apotem;

            Console.WriteLine(MsgEnterOption);
            Console.WriteLine(MsgOptions);
            Console.Write(MsgUserOption);

            userElection = Convert.ToInt16(Console.ReadLine());

            switch (userElection)
            {
                case 1:
                    Console.Write(MsgSide);
                    side = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(AreaCalculator(side, elevateNumber));
                    break;

                case 2:
                    Console.Write(MsgSide);
                    side = Convert.ToDouble(Console.ReadLine());

                    Console.Write(MsgHeight);
                    height = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(AreaCalculator(side, height));
                    break;

                case 3:
                    Console.Write(MsgRadius);
                    radius = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(AreaCalculator(radius, piNumber, elevateNumber));
                    break;

                case 4:
                    Console.Write(MsgSide);
                    side = Convert.ToDouble(Console.ReadLine());

                    Console.Write(MsgApotem);
                    apotem = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(AreaCalculator(side, numberOfPentagonSides, apotem, divideNumber));
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
        public static double AreaCalculator(double side, double numSides, double apotem, int divideTo)
        {
            return ((side * numSides) * apotem) / divideTo;
        }
    }
}