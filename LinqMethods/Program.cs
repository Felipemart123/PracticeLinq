using System;
using System.Collections.Generic;
using System.Linq;

List<string> videoGameNames = new() { "Call of Duty", "Fifa", "Super Mario", "Kotor" };

var sortedValues = videoGameNames
    .OrderByDescending(x => x.Length);

foreach (var name in sortedValues)
{
    Console.WriteLine(name);
}


