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
          int numberOne = firstNumber;
          int numberTwo = secondNumber;
          int result1 = (int)Math.Sqrt(numberOne);
          int result2 = (int)Math.Sqrt(secondNumber);
          ViewBag.Result = result1;
          ViewBag.Result = result2;
          return View();
      }
    }
}