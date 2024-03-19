using System;

namespace DisplayInfo
{
    static class Program
    {
        static void Main(string[] args)
        {
            ScreenSize screen = new ScreenSize();
            Console.WriteLine("Диагональ экрана: {0:F2} дюймов", screen.Size());
        }
    }
}
