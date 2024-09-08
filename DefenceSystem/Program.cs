

using DefenceSystem;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("initializing defence tree");
        Task.Delay(4000).Wait();
        DefenceStrategiesBST tree = Service.InitalizeDefenceStrategiesBST();

        Console.WriteLine("Printing Defence Strategies BST");
        Task.Delay(4000).Wait();
        tree.PreOrderTraversal(tree.Root);

        Console.WriteLine("geting threats from json");
        Task.Delay(4000).Wait();
        List<Threat> allThreats = Service.ReadThreats();


        foreach (Threat threat in allThreats)
        {
            threat.RunThreat(tree);
        }




    }
}