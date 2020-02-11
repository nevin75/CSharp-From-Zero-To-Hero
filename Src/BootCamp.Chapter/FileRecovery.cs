using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    class FileRecovery
    {
        public static void RemoveErrantCharacter()
        {
            const string newFile = @"C:\Git\CSharp-From-Zero-To-Hero\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances.repaired";

            const string file = @"C:\Git\CSharp-From-Zero-To-Hero\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances.corrupted";

            StreamWriter writer = new StreamWriter(newFile, true);
            StreamReader reader = new StreamReader(file, true);

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


