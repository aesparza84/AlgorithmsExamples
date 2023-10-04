using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FileToFisherYatesShuffle
{
    public class ReadingFile
    {
        //We take a text file, then split it up on the commas to add it to an array


        private StreamReader reader;
        private string text;

        public string[] letters;
        public ReadingFile() 
        {
            //The file that this is reading from is in bin > Debug > net6.0
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Letters.txt");

            reader = new StreamReader(path);
            //reader = new StreamReader("C:\\Workspace\\GitHub\\Algorithms\\AlgorithmsExamples\\FileImportShuffle\\FileToFisherYatesShuffle\\FileToFisherYatesShuffle\\Letters.txt");

            text = reader.ReadToEnd();
            letters= text.Split(new char[] {','});
        }
    }
}
