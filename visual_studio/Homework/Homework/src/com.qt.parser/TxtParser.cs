using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.src.com.qt.parser
{
    class TxtParser
    {
        private StreamReader sr;

        private readonly Encoding fileEncoding = Encoding.Default;

        public TxtParser()
        {
        }

        ~TxtParser()
        {
            if (sr != null)
            {
                sr.Close();
            }
        }

        public bool ParserFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error : cannot find file.");
                return false;
            }

            return CreateFileStreamReader(filePath);
        }

        private bool CreateFileStreamReader(string filePath)
        {
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
                sr = new StreamReader(fs, fileEncoding);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public string GetNextLineString()
        {
            return sr.ReadLine();
        }
    }
}
