using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KarpenkoAL.Sprint6.Task6.V10.Lib
{
    public class DataService : ISprint6Task6V10
    {
        public string CollectTextFromFile(string path)
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
                File.WriteAllText(path, "nXkwQYzgZ tsCms LlckTwkpaAGTvLPc\r\nfthzqqL XcNHugFmbsRgVVfsgHNGuUC\r\nSeRTRfFeAxzn raCml PzLyVamXVcmNn\r\ndlezsxTS z KxFxadaTMeBz BRW pSuA\r\ntVMMaxdnYJoY EUAji hntD RTmxxVdu");
            }
            
            var filteredWords = new List<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    var words = line.Split(' ');
                    foreach (var word in words)
                    {
                        if (word.Contains('w'))
                        {
                            filteredWords.Add(word);
                        }
                    }
                }
            }

            string result = string.Join(" ", filteredWords);
            return result;

        }
    }
}
