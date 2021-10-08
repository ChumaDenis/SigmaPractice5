using System;

using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Zavd1
{
    class Zavd
    {

        private string result = @"C:\Users\admin\source\repos\Zavd1\Zavd1\result.txt";
        private int count;
        public Zavd(string path)
        {
            string[] readText = File.ReadAllLines(path);
            string[] sub;
            for (int i = 0; i < readText.Length; i++)
            {
                sub = readText[i].Split(' ');

                Amou_Chang(sub);
                Res(sub);
            }

        }


        public void Amou_Chang(string[] sub)
        {
            int count = 0;
            int esi = 0;
            for (int i = 0; i < sub.Length; i++)
            {
                if (sub[i] == "#")
                {
                    count++;
                }
            }
            this.count = count;
            for (int i = 0; i < sub.Length; i++)
            {
                if (sub[i] == "#" && esi < count / 2)
                {
                    sub[i] = "<";
                    esi++;
                }
                else if (sub[i] == "#")
                {
                    sub[i] = ">";
                }
            }



        }


        public void Res(string[] sub)
        {
            string text = sub[0];
            for (int i = 1; i < sub.Length; i++)
            {
                text += sub[i] + " ";
            }
            if (count % 2 != 0)
            {
                text += ">";
            }
            text += "\n";
            File.AppendAllText(result, text);

        }

    }

    class Program
    {
        //C:\Users\admin\source\repos\Zavd1\Zavd1\path.txt
        static void Main(string[] args)
        {
            string path = @"";
            Console.WriteLine("Enter path to file");
            path = Console.ReadLine();
            Zavd ftry = new Zavd(path);
        }
    }
}
