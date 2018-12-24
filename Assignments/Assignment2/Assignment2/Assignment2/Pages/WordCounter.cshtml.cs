using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment2.Pages
{
    public class WordCounterModel : PageModel
    {
        [DisplayName("First Name")]
        public string WordCounter { get; private set; } ="";
        public Dictionary<string, int> WordDict { get; set; }
        public void OnGet()
        {
            WordCounter += "";
            WordDict = new Dictionary<string, int>();
        }

        public void OnPost(string wordCounter, Dictionary<string,int>wordDict)
        {
            WordCounter = wordCounter;
            try
            {
                string output = wordCounter;
                string[] words = output.Split(' ');
                wordDict = new Dictionary<string, int>();
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
                WordDict = wordDict;
            }
            catch(Exception e)
            {
                e.ToString();
            }
            
        }
    }
}