﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Day1
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("../../input.txt");
            var line = reader.ReadLine().ToCharArray();
            var digits = line.Select(x => (int) Char.GetNumericValue(x)).ToArray();
            var sum = digits.Where((t, i) => t == digits[(i + 1) % digits.Length]).Sum();
            Console.WriteLine(sum);
        }
    }
}
