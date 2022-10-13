using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пианииининининининно
{
    internal class Program
    {
        static void Main()
        {
          
            int[] thirdOctave = new int[12]
                {130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246};
            int[] sixthOctave = new int[12]
                    {047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976};
            vyborOctavi(thirdOctave, sixthOctave);
        }




        static void ThirdOctave(int[] thirdOctave, int[] sixthOctave)
        {
            Console.WriteLine("Вы выбрали 3-ю октаву.");
            Console.WriteLine("Во премя использования пианино используйте белые(A-H) и чёрные клавиши(Q-Y)." +
                 "\r\nЕсли вы хотите поменять октаву, нажмите на клавишу 'F6'. " +
                 "\r\nЕсли вы хотите вернуться к начальному выбору октав, нажмите на сочетание клавиш 'Ctrl' + 'Enter'.");
            while (true)
            {

                ConsoleKeyInfo clavisha = Console.ReadKey();
                if (clavisha.Key == ConsoleKey.A)
                    Console.Beep(thirdOctave[0], 200);
                else if (clavisha.Key == ConsoleKey.Q)
                    Console.Beep(thirdOctave[1], 200);
                else if (clavisha.Key == ConsoleKey.S)
                    Console.Beep(thirdOctave[2], 200);
                else if (clavisha.Key == ConsoleKey.W)
                    Console.Beep(thirdOctave[3], 200);
                else if (clavisha.Key == ConsoleKey.D)
                    Console.Beep(thirdOctave[4], 200);
                else if (clavisha.Key == ConsoleKey.E)
                    Console.Beep(thirdOctave[5], 200);
                else if (clavisha.Key == ConsoleKey.F)
                    Console.Beep(thirdOctave[6], 200);
                else if (clavisha.Key == ConsoleKey.R)
                    Console.Beep(thirdOctave[7], 200);
                else if (clavisha.Key == ConsoleKey.G)
                    Console.Beep(thirdOctave[8], 200);
                else if (clavisha.Key == ConsoleKey.T)
                    Console.Beep(thirdOctave[9], 200);
                else if (clavisha.Key == ConsoleKey.H)
                    Console.Beep(thirdOctave[10], 200);
                else if (clavisha.Key == ConsoleKey.Y)
                    Console.Beep(thirdOctave[11], 200);
                else if (clavisha.Key == ConsoleKey.F6)
                {
                    Console.Clear();
                    SixthOctave(sixthOctave, thirdOctave);
                }
                else if (clavisha.Modifiers.HasFlag(ConsoleModifiers.Control) && clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Main();
                }
                
            }



        }
        static void SixthOctave(int[] sixthOctave, int[] thirdOctave)
        {
            Console.WriteLine("Вы выбрали 6-ю октаву.");
            Console.WriteLine("Во премя использования пианино используйте белые(A-H) и чёрные клавиши(Q-Y)." +
                "\r\nЕсли вы хотите поменять октаву, нажмите на клавишу 'F3'. " +
                "\r\nЕсли вы хотите вернуться к начальному выбору октав, нажмите на сочетание клавиш 'Ctrl' + 'Enter'.");
            while (true)
            {

                ConsoleKeyInfo clavisha = Console.ReadKey();
                if (clavisha.Key == ConsoleKey.A)
                    Console.Beep(sixthOctave[0], 200);
                else if (clavisha.Key == ConsoleKey.Q)
                    Console.Beep(sixthOctave[1], 200);
                else if (clavisha.Key == ConsoleKey.S)
                    Console.Beep(sixthOctave[2], 200);
                else if (clavisha.Key == ConsoleKey.W)
                    Console.Beep(sixthOctave[3], 200);
                else if (clavisha.Key == ConsoleKey.D)
                    Console.Beep(sixthOctave[4], 200);
                else if (clavisha.Key == ConsoleKey.E)
                    Console.Beep(sixthOctave[5], 200);
                else if (clavisha.Key == ConsoleKey.F)
                    Console.Beep(sixthOctave[6], 200);
                else if (clavisha.Key == ConsoleKey.R)
                    Console.Beep(sixthOctave[7], 200);
                else if (clavisha.Key == ConsoleKey.G)
                    Console.Beep(sixthOctave[8], 200);
                else if (clavisha.Key == ConsoleKey.T)
                    Console.Beep(sixthOctave[9], 200);
                else if (clavisha.Key == ConsoleKey.H)
                    Console.Beep(sixthOctave[10], 200);
                else if (clavisha.Key == ConsoleKey.Y)
                    Console.Beep(sixthOctave[11], 200);
                else if (clavisha.Key == ConsoleKey.F3)
                {
                    Console.Clear();
                    ThirdOctave(thirdOctave, sixthOctave);
                }
                else if (clavisha.Modifiers.HasFlag(ConsoleModifiers.Control) && clavisha.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Main();
                }
            

            }





        }
        static void vyborOctavi(int[] thirdOctave, int[] sixthOctave)
        {
            while (true)
            {
                Console.WriteLine("Выберите октаву:\r\n Нажмите 'F3' для выбора 3-й октавы или 'F6' для выбора 6-й октавы.\r\nДля выхода нажмите на 'Escape'.");
                ConsoleKeyInfo clavisha = Console.ReadKey();
                Console.Clear();
                if (clavisha.Key == ConsoleKey.F3)
                    ThirdOctave(thirdOctave, sixthOctave);
                if (clavisha.Key == ConsoleKey.F6)
                    SixthOctave(sixthOctave, thirdOctave);
                if (clavisha.Key == ConsoleKey.Escape)
                    Environment.Exit(0);
                else
                {
                    Console.WriteLine("\r\nВыберите верную октаву");
                    Console.Clear();
                }
            }
        }
    }
}
