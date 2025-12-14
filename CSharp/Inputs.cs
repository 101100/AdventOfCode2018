using System.IO;
using System.Reflection;

namespace AdventOfCode2018.CSharp
{

    public static class Inputs
    {

        public static string GetInput(int day)
        {
            return Inputs.GetDataFileText($"day{day:00}.txt");
        }


        private static string GetDataFileText(string filename)
        {
            return File.ReadAllText(Path.Combine(
                Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
                "..",
                "..",
                "..",
                "..",
                "inputs",
                filename));
        }

    }

}
