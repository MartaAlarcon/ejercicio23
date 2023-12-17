using Microsoft.VisualBasic.FileIO;
using System;
using System.Runtime.CompilerServices;

namespace Activitats
{
    public class ej23
    {
        public static void Main()
        {
            int option, b, height, radius, lenght, apotema;
            const string MsgChoose = "Escull l'àrea de quina figura vols calcular: 1 - quadrat, 2 - rectangle, 3 - cercle, 4 - pentàgon";
            const string MsgBase = "Escriu la base: ";
            const string MsgHeight = "Escriu l'alçada: ";
            const string MsgRadius = "Escriu el radi: ";
            const string MsgLenght = "Escriu la longitud: ";
            const string MsgApotema = "Escriu l'apotema: ";
            do
            {
                Console.WriteLine(MsgChoose);
                option = Convert.ToInt32(Console.ReadLine());
            } while ((option != 1) && (option != 2) && (option != 3) && (option != 4));
            switch (option)
            {
                case 1:
                    Console.WriteLine(MsgBase);
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(MsgHeight);
                    height = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(AreaSquareRectangle(b, height));
                    break;
                case 2:
                    Console.WriteLine(MsgBase);
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(MsgHeight);
                    height = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(AreaSquareRectangle(b, height));
                    break;
                case 3:
                    Console.WriteLine(MsgRadius);
                    radius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(AreaCircle(radius));
                    break;
                case 4:
                    Console.WriteLine(MsgLenght);
                    lenght = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(MsgApotema);
                    apotema = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(AreaPentagon(lenght, apotema));
                    break;
            }
            static int AreaSquareRectangle(int b, int height)
            {
                int result;
                result = b * height;
                return result;
            }
             static double AreaCircle(int radius)
            {
                double result;
                result = Math.PI * (radius * radius);
                return result;
            }
             static double AreaPentagon(int lenght, int apotema)
            {
                double result;
                result = ((5 * lenght * apotema) / 2);
                return result;
            }
        }
    }
}