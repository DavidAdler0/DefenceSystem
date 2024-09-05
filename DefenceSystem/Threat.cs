using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenceSystem
{
    internal class Threat
    {
        public string ThreatType { get; set; }
        public int Volume { get; set; }
        public int Sophistication { get; set; }
        public string Target { get; set; }
        public void RunThreat(DefenceStrategiesBST tree)
        {
            int severity = CalculateSeverity();
            Console.WriteLine("Calculating severity");
            Task.Delay(4000).Wait();


            int min = tree.FindMin();
            if (severity < min)
            {
                Console.WriteLine("Attack severity is below the threshold. Attack is ignored");
            }

            DefenceStrategiesNode defenceNode = tree.FindDefence(severity);
            if (defenceNode == null)
            {
                Console.WriteLine("No suitable defence was found. Brace for impact!");
            }
            else
            {
                foreach (string defence in defenceNode.Defenses)
                {
                    Console.WriteLine(defence);
                    Task.Delay(2000).Wait();
                }
                Console.WriteLine("Runing Defence");
                Task.Delay(4000).Wait();

            }



        }

        public int CalculateSeverity()
        {
            Dictionary<string, int> TargetValues = new Dictionary<string, int> { { "Web Server", 10 }, { "Database", 15 }, { "User Credentials", 20 } };
            int targetValue = TargetValues.TryGetValue(Target, out var value) == true ? value : 5;
            int severity = Volume * Sophistication + targetValue;
            return severity;
        }




    }

}
