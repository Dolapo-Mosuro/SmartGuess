using System;
using Microsoft.AspNetCore.Mvc;

namespace SmartGuess.Controllers
{
    public class SmartGuess : Controller
    {
      public ActionResult SquareRoot()
      {
          return View();
      }
      [HttpPost]
      public ActionResult SquareRoot(int firstNumber, int secondNumber)

      {
<<<<<<< Updated upstream
          if (firstNumber == null || secondNumber == null)
          {
              ViewBag.error = "show error";
          }
=======
         // if (firstNumber == null || secondNumber == null)
         // {
          //    ViewBag.error = "show error";
        //  }
>>>>>>> Stashed changes

        if (firstNumber > secondNumber)
               {

                ViewBag.Result("The first number was greater than the second number");

               }

<<<<<<< Updated upstream
        if (firstNumber > secondNumber)
               {

                ViewBag.Result("The first number was greater than the second number");
=======
        if (firstNumber < secondNumber)
               {

                ViewBag.Result("The first number was lesser than the second number");
>>>>>>> Stashed changes

               }       

          int numberOne = firstNumber;
          int numberTwo = secondNumber;
          int result1 = (int)Math.Sqrt(firstNumber);
          int result2 = (int)Math.Sqrt(secondNumber);
          ViewBag.Result = result1;
          ViewBag.Result = result2;
          return View();
      }
    }
}