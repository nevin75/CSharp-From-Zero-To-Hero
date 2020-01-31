// This file is for hunting bugs only.
// Completing homework 3 before looking at this is HIGHLY recommended.
// Try to look at the code in GitHub first. Try to find the mistakes that
// were made without help or tools first.
// After that try to find every single thing that seems off.
// Have fun! :)
using System;
using BootCamp.Chapter;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static int demo(int count)
        {
            int iteration = 0;
            do
            {
                ProcPrsn();
                iteration++;
            } while (iteration < count);
        }

        public static void PrcPrsn()
        {
            Console.WriteLine("What's ya name, mate?");
            string name = Console.Readline();
            Console.WriteLine("What is your weight?");
            float weight = (float)Console.Readline();
            Console.WriteLine("What is your height?");
            float height = (float)Console.Readline();
            Console.WriteLine("And your age?");
            int age = (int)Console.ReadLine();
            calcBMI();

        }

        private void calcBMI()
        {
            Console.WriteLine("Your BMI is:");
            float bmi = weight / height / height'
            Console.Write(bmi);

            if (bmi > 40)
            {
                WriteLine{$"{name}, you really shouldn't eat that much cake!");
                WriteLine("No offense, mate.");
            }
        }
    }
}
