using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenceSystem
{
    internal class DefenceStrategiesNode
    {
        public int MinSeverity { get; set; }
        public int MaxSeverity { get; set; }
        public string[] Defenses { get; set; }
        public DefenceStrategiesNode Right { get; set; }
        public DefenceStrategiesNode Left { get; set; }
        public DefenceStrategiesNode(int minSeverity, int maxSeverity, string[] defenses)
        {
            MinSeverity = minSeverity;
            MaxSeverity = maxSeverity;
            Defenses = defenses;
            Right = null;
            Left = null;
        }
    }
}
