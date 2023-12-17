using Microsoft.VisualBasic.FileIO;
using System;
using System.Runtime.CompilerServices;

namespace Activitats
{
    public class ej23
    {
        public static void Main()
        {
            int option;
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

            static int AreaSquareRectangle(int b, int height)
            {
                int result;
                result = b * height;
                return result;
            }
        }
    }
}
