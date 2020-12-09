using System;

namespace SetterGetter
{
    internal class Box
    {
        private int length;
        private int heigth;
        private int width;
        public int volume;

        public Box(int length, int heigth)
        {
            this.length = length;
            this.heigth = heigth;
        }

        /* public void SetBoxWidth(int width)
         {
             if (width < 0)
             {
                 throw new Exception("null");
             }
             this.width = width;
         }*/

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                this.width = value;
            }
        }

        public void DisplayBoxInfo()
        {
            this.volume = length * width * heigth;
            Console.WriteLine("Box length is {0}, box heigth is {1}, box width is " +
                "{2} and box volume is {3}", length, heigth, width, volume);
            Console.Read();
        }
    }
}