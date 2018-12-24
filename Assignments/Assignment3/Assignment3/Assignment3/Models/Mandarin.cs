using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class Mandarin
    {
        public Dictionary<string, int> computeMandarin(string data)
        {
            Dictionary<string, int> wordDict = new Dictionary<string, int>(); 
            if (data!=null && Regex.IsMatch(data, "^[\u4E00-\u9FFF]+"))
            {
                char letter;
                for (int i = 0; i < data.Length; i++)
                {
                    letter = data[i];
                    string letter1 = letter.ToString();
                    if (wordDict.ContainsKey(letter1))
                    {
                        wordDict[letter1] += 1;

                    }
                    else
                    {
                        wordDict[letter1] = 1;
                    }
                }
            }
            else
            {
                wordDict.Add("你没有在文本框中输入任何内容", 0);
            }
            
            return wordDict;
        }
    }
}
