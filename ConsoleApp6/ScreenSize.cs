using System;
using System.Windows.Forms;

namespace DisplayInfo
{
    internal class ScreenSize
    {
        private readonly double widthInInches, heightInInches;
        public ScreenSize() 
        {
            foreach (var screen in Screen.AllScreens)
            {
                if(screen.Primary)
                {
                    widthInInches = screen.Bounds.Width / 96.0;
                    heightInInches = screen.Bounds.Height / 96.0;
                }               
            }
        }
        public double Size() => Math.Sqrt(Math.Pow(widthInInches, 2) + Math.Pow(heightInInches, 2));
    }
}
