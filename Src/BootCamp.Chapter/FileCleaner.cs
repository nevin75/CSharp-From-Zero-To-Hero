﻿using System;
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

            if (new FileInfo(dirtyFile).Length == 0)
            {
                throw new ArgumentException();
            }

            //File.WriteAllText(cleanedFile, "a");
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
            ValidateCleanedData(cleanedFile);
        }
        public static void ValidateCleanedData(string cleanedFile)
        {

            if (!File.Exists(cleanedFile))
            {
                InvalidBalancesException e = null;
                throw new InvalidBalancesException("no data in file", e);
            }
/*
            //File.WriteAllText(cleanedFile, "a");
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
            }*/
        }
    }
}






