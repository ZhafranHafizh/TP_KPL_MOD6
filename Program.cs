// See https://aka.ms/new-console-template for more information
namespace tpmodul6_1302210036
{
    class Mainprog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test sayaTubesVideo");
            SayaTubeVideo vid = new SayaTubeVideo("Tutorial Design By Contract – Zhafran Hafizh I.R");
            vid.IncreasePlayCount(1876);
            vid.PrintVideoDetails();

            Console.WriteLine();


            Console.WriteLine("Test DESIGN BY CONTRACT");
            SayaTubeVideo vid2 = new SayaTubeVideo("FaZe vs Cloud9 - ESL Pro League Season 17 - Grand Final");
            vid2.IncreasePlayCount(15000);
            vid2.PrintVideoDetails  ();

            for(int i = 0; i < 10000001; i += 10000000)
            {
                vid.IncreasePlayCount (10000000);
                Console.WriteLine();
            }
            vid.PrintVideoDetails ();
        }
    }
}
