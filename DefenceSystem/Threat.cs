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
            Console.WriteLine($"Calculating severity of threat type {this.ThreatType}");
            Task.Delay(4000).Wait();
            int severity = CalculateSeverity(this);

            Console.WriteLine($"Runing Defence for threat with severity {severity}");
            Task.Delay(4000).Wait();

            int min = tree.FindMin();
            if (severity < min)
            {
                Console.WriteLine("Attack severity is below the threshold. Attack is ignored");
            }

            DefenceStrategiesNode defenceNode = tree.FindDefence(tree.Root, severity);
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

            }



        }

        public int CalculateSeverity(Threat threat)
        {
            Dictionary<string, int> TargetValues = new Dictionary<string, int> { { "Web Server", 10 }, { "Database", 15 }, { "User Credentials", 20 } };
            int targetValue = TargetValues.TryGetValue(Target, out var value) == true ? value : 5;
            int severity = Volume * Sophistication + targetValue;
            return severity;
        }




    }

}
