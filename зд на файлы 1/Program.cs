using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    class Class1
    {
        static void Main()
        {
            try
            {
                FileStream f = new FileStream("test.txt", FileMode.Create, FileAccess.ReadWrite); 
                byte[] x = new byte[10];

                for (byte i = 0; i < 10; ++i)
                {
                    x[i] = (byte)(10 + i);
                }
                f.Write(x, 0, 10);
               
                int count = 0;
                f.Seek(0, SeekOrigin.Begin);
                for (int i = 0; i < 10; i++)
                {
                   int a = f.ReadByte(); if (a % 2 == 0)
                    {
                        Console.Write(a + " ");
                    }
                    else
                    {
                        count += 1;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("нечетные числа -> " + count);
                Console.WriteLine(); 
                Console.WriteLine("текущая позиция ->" + f.Position);
                f.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ошибка работы с файлом: " + e.Message);
            }
        }
    }
}