using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HW3Site.Models;
//using static HW3Site.Models.Question.Initial;

namespace HW3Site.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
        Question[] QArray = HW3Site.Models.Question.Initial();

        Random rnd = new Random();
        int num = HW3Site.Models.Question.num;
        num = rnd.Next(0, 3); 
        Question pass = QArray[num];

          return View("Index", pass); // parts.Add(new Part() {PartName="crank arm", PartId=1234});
            //need to return random questions each time
        }

        [HttpPost]
         public IActionResult QuestionSubmit(string answer)
        {
            Question[] QArray = HW3Site.Models.Question.Initial();

            // foreach (var q in QArray)
            //     {
            //         foreach(var ans in q.Answers)
            //         {
            //              if(ans.AnswerText == answer && ans.IsCorrect == true)
            //                 {
            //                     return View("GoodJob");
            //                 }    
            //         }
                   
                // }
            int num = HW3Site.Models.Question.num;

            return View("Index", QArray[num]);
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

        public IActionResult Error()
        {
            return View();
        }
    }
}
