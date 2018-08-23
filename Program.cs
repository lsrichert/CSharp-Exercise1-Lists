using System;
using System.Collections.Generic;

namespace exercise1List
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main method, place the following code
            List<string> planetList = new List<string>() {"Mercury", "Mars"};

            // 1.  Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            // 2. Create another List that contains that last two planet of our solar system.
            List<string> planetListNew = new List<string>(){"Uranus", "Neptune"};

            // 3. Combine the two lists by using AddRange().
            planetList.AddRange(planetListNew);

            // 4. User Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(3, "Earth");
            planetList.Insert(2, "Venus");

            // 5. Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");

            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            // 6. Now that all the planets are in the list, slice the list using GetRange() in order to extract 
            // the rocky planets into a new list called rockyPlanets.
            List<string> rockyPlanets = planetList.GetRange(0, 4);

            foreach (string rockyPlanet in rockyPlanets)
            {
                Console.WriteLine(rockyPlanets);
            }

            // 7. Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method 
            // to eliminate it from the end of planetList.
            planetList.Remove("Pluto");

            // foreach (string planet in planetList);
            // {
            //     Console.WriteLine(planetList);
            // }

// Empty list of probes
            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();

            // Create probe
            Dictionary<string, string> viking = new Dictionary<string, string>() {
                { "Mars", "Viking" }
            };

            // Create probe
            Dictionary<string, string> opportunity = new Dictionary<string, string>() {
                { "Mars", "Opportunity" }
            };

            // Create probe
            Dictionary<string, string> mariner10 = new Dictionary<string, string>() {
                { "Mercury", "Mariner 10" }
            };

            // Add probes to the List
            probes.Add(viking);
            probes.Add(opportunity);
            probes.Add(mariner10);

            /*
                The planet name itself is essentially a foreign key in the probes
                list back to the planet list.
                Iterate over all the planets.
             */
            foreach (string planet in planetList)
            {
                // Build an initial list of string to hold the matching probe names
                List<string> visitedProbes = new List<string>();

                // Iterate over all the probes
                foreach (Dictionary<string, string> probe in probes)
                {
                    /*
                        Does the current planet name in the dictionary match
                        the name of the planet in the planet list
                     */
                    if (probe.ContainsKey(planet)) {
                        visitedProbes.Add(probe[planet]);
                    }

                }

                // Output the name of the planet and comma separated list of matching probes
                Console.WriteLine($"{planet}: {String.Join(", ", visitedProbes)}");
            }



          }

    }
}
