using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class English
    {
        public Dictionary<string, int> computeEnglish(string data)
        {
            Dictionary<string, int> wordDict = new Dictionary<string, int>();
            if(Regex.IsMatch(data, "^[\u4E00-\u9FFF]+") || Regex.IsMatch(data, "^[\u0900-\u097F]+"))
            {
                wordDict.Add("You entered something incorrect in the textbox", 0);
            }
            else
            {
                char[] delimiterChars = { ' ', ',', '.', ':' };
                string[] words = data.Split(delimiterChars);
                foreach (var word in words)
                {
                    if (wordDict.ContainsKey(word))
                    {
                        wordDict[word] += 1;

                    }
                    else
                    {
                        wordDict[word] = 1;
                    }
                }
            }
            return wordDict;
        }
    }
}

