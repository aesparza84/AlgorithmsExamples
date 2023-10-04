using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileToFisherYatesShuffle
{
    public class ReadingFile
    {
        private StreamReader reader;
        string text;
        public string[] letters;
        public ReadingFile() 
        {
            reader = new StreamReader("C:\\Workspace\\GitHub\\Algorithms\\AlgorithmsExamples\\FileImportShuffle\\FileToFisherYatesShuffle\\FileToFisherYatesShuffle\\Letters.txt");
            text = reader.ReadToEnd();
            letters= text.Split(new char[] {','});
        }
    }
}
