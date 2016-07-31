using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework.src.com.qt.parser;
using Homework.src.com.qt.sqlink;

namespace Homework
{
    class Program
    {
        private static string FilePath = @"../../d.txt";

        static void Main(string[] args)
        {
            TxtParser Parser = new TxtParser();
            if (Parser.ParserFile(FilePath))
            {
                SeqlinkListQt<string> linkListQt = new SeqlinkListQt<string>();
                ParserText(Parser, linkListQt);
                linkListQt.Print();
            }
        }

        private static void ParserText(TxtParser pasrer, SeqlinkListQt<string> linkListQt)
        {
            string content = pasrer.GetNextLineString();
            while (content != null)
            {
                linkListQt.Append(content);
                content = pasrer.GetNextLineString();
            }
        }
    }
}