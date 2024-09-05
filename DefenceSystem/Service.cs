using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DefenceSystem
{
    internal static class Service
    {
        public static DefenceStrategiesBST InitalizeDefenceStrategiesBST()
        {
            var json = File.ReadAllText("C:\\Users\\adler\\source\\repos\\DefenceSystem\\DefenceSystem\\defenceStrategiesBalanced.json");

            var defenceArray = System.Text.Json.JsonSerializer.Deserialize<List<DefenceStrategiesNode>>(json);
            DefenceStrategiesBST defenceStrategiesBST = new DefenceStrategiesBST();
            foreach (var item in defenceArray)
            {
                defenceStrategiesBST.Insert(item.MinSeverity, item.MaxSeverity, item.Defenses);
            }
            return defenceStrategiesBST;
        }
        public static List<Threat> ReadThreats()
        {
            var json = File.ReadAllText("C:\\Users\\adler\\source\\repos\\DefenceSystem\\DefenceSystem\\Threts.json");
            List<Threat> threatsArray = System.Text.Json.JsonSerializer.Deserialize<List<Threat>>(json);
            return threatsArray;
        }


    }
}
