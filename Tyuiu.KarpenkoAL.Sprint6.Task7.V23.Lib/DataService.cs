using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KarpenkoAL.Sprint6.Task7.V23.Lib
{
    public class DataService : ISprint6Task7V23
    {
        public int[,] GetMatrix(string path)
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
                string csv = @"6;15;-9;-11;-4;-20;-18;6;6;1
18;-8;6;-7;-10;-5;5;20;-18;-6
-5;-8;12;-14;1;-20;-5;-20;-5;0
-20;7;-7;10;-13;-12;-18;4;4;4
-1;19;17;3;-15;-1;-5;15;-4;-5
4;-10;-17;11;-1;-14;6;8;3;19
14;4;-15;19;-19;11;-5;13;6;7
-8;13;-6;-20;17;-8;19;15;-15;-3
4;-18;-20;-12;5;20;-2;-10;-9;10
-8;-20;-8;-11;7;0;-7;5;-20;-5
";
                File.WriteAllText(path, csv);
            }

            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length; 

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';'); 
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, columns - 1] < 2)
                    matrix[i, columns - 1] = 2;
            }

            string tempPath = Path.GetTempPath();
            string pathSaveFile = Path.Combine(tempPath, "OutPutFileTask7.csv");

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    output.Append(matrix[i, j]);
                    if (j != columns - 1)
                    {
                        output.Append(";");
                    }
                }
                if (i != rows - 1)
                {
                    output.AppendLine();
                }
            }

            File.WriteAllText(pathSaveFile, output.ToString());

            return matrix;
        }
    }
}
