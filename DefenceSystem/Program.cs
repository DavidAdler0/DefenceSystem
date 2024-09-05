

using DefenceSystem;

internal class Program
{
    private static void Main(string[] args)
    {
        DefenceStrategiesBST tree = Service.InitalizeDefenceStrategiesBST();
        Console.WriteLine("initializing defence tree");
        Task.Delay(4000).Wait();

        tree.PrintDefenceStrategiesBST();
        Console.WriteLine("Printing Defence Strategies BST");
        Task.Delay(4000).Wait();

        //Threat[] allThreats = Service.ReadThreats().AllThreats;
        //Console.WriteLine("geting threats from json");
        //Task.Delay(4000).Wait();


        //foreach (Threat threat in allThreats)
        //{
        //    threat.RunThreat(tree);
        //}




    }
}