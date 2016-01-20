using System;
using System.IO;
using System.Reflection;

namespace AlgorithmsPrometheus
{
    class Helper
    {
        public static void WriteResultsToFile(object product)
        {
            string path = Assembly.GetExecutingAssembly().Location.Replace("exe", "txt");
            if (File.Exists(path))
                File.Delete(path);
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(product.ToString());
            }

            Console.WriteLine(String.Concat("See results in file : \n", path));
        }
    }
}
