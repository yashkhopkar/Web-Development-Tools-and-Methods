using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class Hindi
    {
        public Dictionary<string, int> computeHindi(string data)
        {
            Dictionary<string, int> wordDict = new Dictionary<string, int>();
            if (data != null && Regex.IsMatch(data, "^[\u0900-\u097F]+"))
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
            else
            {
                wordDict.Add("आपने टेक्स्ट बॉक्स में कुछ गलत दर्ज किया है!", 0);
            }
            
            return wordDict;
        }
    }
}
