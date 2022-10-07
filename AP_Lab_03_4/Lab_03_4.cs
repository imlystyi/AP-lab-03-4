// Lab_03_4.cs
// Якубовський Владислав
// Лабораторна робота № 3.4
// Розгалуження, задане плоскою фігурою.
// Варіант 24
using System;

namespace AP_Lab_03_4
{
    internal class Lab_03_4
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Введіть змінні \"x\", \"y\" та \"R\" по черзі через крапку з комою: ");

            string[] varArray = Console.ReadLine().Split(';');

            double x = Double.Parse(varArray[0].Replace('.', ',')),
                y = Double.Parse(varArray[1].Replace('.', ',')),
                R = Double.Parse(varArray[2].Replace('.', ','));

            /* -R <= x <= R; 0 <= y <= R; x^2 + y^2 <= R^2 -> true;
             * x > y; -R < y < 0 -> true. */
            bool result;

            if (x >= -R && x <= R && y >= 0 && y <= R && (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2)))
                result = true;

            else if (x > y && y > -R && y < 0)
                result = true;

            else result = false;

            // Частина виведення.
            Console.Write("Чи попадає точка з заданими координатами \"x, y\" та змінною \"R\" у область зафарбованої фігури: " + (result ? "так" : "ні"));

            Console.ReadLine();
        }
    }
}
