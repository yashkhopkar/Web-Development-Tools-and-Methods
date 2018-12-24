using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult WordCounter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult English(WordCounterModel wc)
        {
            string output = wc.WordCounter;
            English english = new English();
            wc.wordDict = english.computeEnglish(output);
            return View(wc);
        }

        
        [HttpPost]
        public IActionResult Hindi(WordCounterModel wc)
        {
            string output = wc.WordCounter;
            Hindi hindi = new Hindi();
            wc.wordDict=hindi.computeHindi(output);
            return View(wc);
        }

        [HttpPost]
        public IActionResult Mandarin(WordCounterModel wc)
        {
            string output = wc.WordCounter;
            Mandarin mandarin = new Mandarin();
            wc.wordDict = mandarin.computeMandarin(output);
            return View(wc);
        }
    }
}
