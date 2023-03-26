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
        }
    }
}
