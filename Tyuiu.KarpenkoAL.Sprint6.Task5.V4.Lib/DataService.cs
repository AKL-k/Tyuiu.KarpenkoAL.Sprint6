using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KarpenkoAL.Sprint6.Task5.V4.Lib
{
    public class DataService : ISprint6Task5V4
    {
        public double[] LoadFromDataFile(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException("Path cannot be null or empty", nameof(path));
            }

            string? directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "1\r\n2,5\r\n3\r\n-1\r\n-2,6\r\n-3\r\n0\r\n5,7\r\n-5\r\n6\r\n-6,8\r\n7\r\n-7\r\n8\r\n-8\r\n9,9\r\n-9\r\n10\r\n-10\r\n0");
            }

            List<double> result = new List<double>();

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(',', '.');

                    if (double.TryParse(line, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out double x))
                    {
                        if (x % 1 == 0)
                        {
                            result.Add(x);
                        }
                    }
                }
            }

            return result.ToArray();
        }
    }
}
