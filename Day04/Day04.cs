﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCodeInputReader;
using Day04.Properties;

namespace Day04
{
    class Day04
    {
        static void Main(string[] args)
        {
            var aocInputReader = new AoCInputReader(Settings.Default.SessionCookie);
            var lines = aocInputReader.GetInputForDay(4).Result;

            var phrases = lines.Select(x => x.Split(' ')).ToArray();
            var wordsList = new List<string>();
            var count = 0;
            foreach (var phrase in phrases)
            {
                for (var i =0; i < phrase.Length; i++)
                {
                    if (!wordsList.Contains(phrase[i]))
                    {
                        wordsList.Add(phrase[i]);
                    }
                    if (wordsList.Count == phrase.Length && i == phrase.Length - 1)
                    {
                        count++;
                    }
                }
                wordsList.Clear();
            }
            Console.WriteLine(count);
        }
    }
}
