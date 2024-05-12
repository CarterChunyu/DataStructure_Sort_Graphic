using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace 資料結構
{
    public class TestHelper
    {
        public static List<string> ReadFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            List<string> words = new List<string>();
            while (!sr.EndOfStream)
            {
                string contents = sr.ReadLine().Trim();

                int start = FirstCharacterIndex(contents, 0);

                for (int i = start+1; i <= contents.Length;)
                {
                    if (i == contents.Length || !char.IsLetter(contents[i]))
                    {
                        string word = contents.Substring(start, i - start).ToLower();
                        words.Add(word);
                        start = FirstCharacterIndex(contents, i);
                        i = start + 1;
                    }
                    else
                        i++;
                }
            }

            fs.Close();
            sr.Close();

            return words;
        }

        private static int FirstCharacterIndex(string s, int start)
        {
            for (int i = start; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                    return i;
            }
            return s.Length;
        }
    }
}
