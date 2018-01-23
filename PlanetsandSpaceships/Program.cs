using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsandSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> planetList2 = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(planetList2);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            planetList.Remove("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            var spacecraft = new Dictionary<string, List<string>>
            {
                {"Mariner", new List<string> { "Venus", "Mars", "Mercury"} },
                {"Messenger", new List<string> { "Mercury"} },
                {"Voyager 1", new List<string> { "Saturn"} },
                {"Viking", new List<string> {"Mars" } },
                {"Voyager 2", new List<string> {"Uranus", "Neptune" } },
                {"Pioneer 10", new List<string> {"Jupiter" } },
                {"Galileo", new List<string> {"Earth"} }
            };

            foreach (var planet in planetList)
            {
                foreach (var craft in spacecraft)
                {
                    if (craft.Value.Contains(planet))
                    {
                        Console.WriteLine($"{craft.Key} visited: {planet}");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
