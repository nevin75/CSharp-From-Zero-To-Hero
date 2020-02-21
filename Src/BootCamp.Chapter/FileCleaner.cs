using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    public static class FileCleaner
    {
        /// <summary>
        /// Cleans up dirtyFileName 
        /// </summary>
        /// <param name="dirtyFile">Dirty file with "_" placed in random places.</param>
        /// <param name="cleanedFile">Cleaned up file without any "_".</param>
        public static void Clean(string dirtyFile, string cleanedFile)
        {
            
            //File.WriteAllText(cleanedFile, "a");
            StreamWriter writer = new StreamWriter(cleanedFile, true);
            StreamReader reader = new StreamReader(dirtyFile, true);

            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    char currentChar = (char)reader.Read();
                    if (new FileInfo (dirtyFile).Length == 0)
                    {
                        throw new ArgumentException();
                    }
                    if (currentChar == '_')
                    {
                        continue;
                    }
                    else
                    {
                        writer.Write(currentChar);
                    }
                }
            }
        }
        public static void RemoveErrantCharacter()
        {
        
            const string cleanedFile = @"C:\Git\CSharp-From-Zero-To-Hero\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances.repaired";

            const string dirtyFile = @"C:\Git\CSharp-From-Zero-To-Hero\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances.corrupted";

            StreamWriter writer = new StreamWriter(cleanedFile, true);
            StreamReader reader = new StreamReader(dirtyFile, true);

            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    char currentChar = (char)reader.Read();
                    if (currentChar == '_')
                    {
                        continue;
                    }
                    else
                    {
                        writer.Write(currentChar);
                    }
                }
            }
        }
    }
}

