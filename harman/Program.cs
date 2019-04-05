
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace harman
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
        }
        public void Run()
        {
            this.ReadTextFiles();
        }

        public void ReadTextFiles()
        {
            //Read file using StreamReader.Reads file line by line
            using (StreamReader file = new StreamReader(@"U:\Users\725563\harman.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                    counter++;

                }
                file.Close();
                Console.WriteLine($"File has{counter}lines");
            }
        }
        public int FindNumberofBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;
            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;
        }


    }
}