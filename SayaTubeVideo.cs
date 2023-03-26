using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210036
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            this.title = title;
            var a  = this.title.Substring(0, Math.Min(100, this.title.Length));
            Contract.Requires(this.title != null);

            String Digit = "";

            Random random = new Random();
            id = random.Next(1, 99999);
            Digit += id.ToString("Digit 5");

            playCount = 0;
        }

        public void IncreasePlayCount(int x)
        {
            if(x <= 10000000)
            {
                for (playCount = 0; playCount <= x;  playCount++)
                {
                    int y = 0;
                    try
                    {
                        y = checked(x + 10);
                    }
                    catch(System.OverflowException b)
                    {
                        Console.WriteLine("Check : " + b.ToString);
                        Console.WriteLine("Data input melebihi limit unputan");
                    }
                }
            }
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " +  playCount);
        }

    }
}
