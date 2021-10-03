using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace StremsFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void Zip()
        {
            string sourceDirector = @"C:\Users\emkat\OneDrive\Работен плот\myFolder";
            string targetDirectory = @"C:\Users\emkat\OneDrive\Работен плот\result.zip";
            string destinationDirectory = @"C:\Users\emkat\OneDrive\Работен плот\result";
            ZipFile.CreateFromDirectory(sourceDirector, targetDirectory);
            ZipFile.ExtractToDirectory(targetDirectory, destinationDirectory);
        }

        private static void DirectoryTraversal()
        {
            string[] allFile = Directory.GetFiles("../../../", ".");
            Dictionary<string, Dictionary<string, double>> groupedFiles = new Dictionary<string, Dictionary<string, double>>();

            foreach (var item in allFile)
            {
                FileInfo fileInfo = new FileInfo(item);
                if (!groupedFiles.ContainsKey(fileInfo.Extension))
                {
                    groupedFiles.Add(fileInfo.Extension, new Dictionary<string, double>());
                }

                double size = (double)fileInfo.Length / 1024;
                groupedFiles[fileInfo.Extension].Add(fileInfo.Name, size);

            }

            var sortedFiles = groupedFiles.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);

            List<string> lines = new List<string>();

            foreach (var item in sortedFiles)
            {
                lines.Add(item.Key);

                foreach (var file in item.Value)
                {
                    lines.Add($"--{file.Key} - {file.Value:f3}kb");
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";

            File.WriteAllLines(path, lines);
        }

        private static void CopyBinaryFile()
        {
            FileStream fileReader = new FileStream("copyMe.png", FileMode.Open);
            FileStream fileWriter = new FileStream("copyMeCopy.png", FileMode.Create);

            byte[] arrayOfBytes = new byte[256];
            while (true)
            {
                int currentBytes = fileReader.Read(arrayOfBytes, 0, arrayOfBytes.Length);
                if (currentBytes == 0)
                {
                    fileWriter.Flush();
                    break;
                }

                fileWriter.Write(arrayOfBytes, 0, arrayOfBytes.Length);
            }
        }

        private static void WordCount()
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string[] wordLines = File.ReadAllLines("words.txt");
            string[] textLines = File.ReadAllLines("text.txt");
            foreach (var item in wordLines)
            {
                if (!wordCount.ContainsKey(item))
                {
                    wordCount.Add(item, 0);
                }

            }
            foreach (var line in textLines)
            {
                foreach (var word in wordCount)
                {
                    if (line.Contains(word.Key, StringComparison.OrdinalIgnoreCase))
                    {
                        wordCount[word.Key]++;
                    }
                }
            }

            foreach (var item in wordCount.OrderByDescending(w => w.Value))
            {
                string result = $"{item.Key} - {item.Value}{Environment.NewLine}";
                File.AppendAllText("actualResult.txt", result);
            }
        }

        private static void LineNumbers()
        {
            string[] lines = File.ReadAllLines("text.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                int lettersCount = lines[i].Count(s => char.IsLetter(s));
                int marks = lines[i].Count(s => char.IsPunctuation(s));

                File.AppendAllText("output.txt", $"Line {i + 1}: {lines[i]} ({lettersCount})({marks}){Environment.NewLine}");
            }
        }

        private static void EvenLines()
        {
            StreamReader sr = new StreamReader(@"..\..\..\text.txt");
            string[] specialSymbols = new[] { "-", ",", ".", "!", "?" };
            bool isEven = true;

            while (true)
            {
                string result = sr.ReadLine();
                if (result == null)
                {
                    break;
                }
                if (!isEven)
                {
                    isEven = true;
                    continue;
                }

                foreach (var item in specialSymbols)
                {
                    result = result.Replace(item, "@");
                }

                Console.WriteLine(string.Join(" ", result.Split().Reverse()));

                isEven = false;
            }
        }
    }
}
