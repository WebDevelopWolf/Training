using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace BasicCalculator.Controllers
{
    public class CalculatorController : ApiController
    {
        public enum Color { Red, Green, Blue }

        [HttpGet]
        [Route("variables")]
        public JsonResult<Int32> Variables()
        {
            var Number = 2;
            return Json(Number);
        }

        [HttpGet]
        [Route("add")]
        public JsonResult<int> Addition ()
        {
            var Result = 0;
            var NumberOne = 2;
            Int32 NumberTwo = 2;
            Result = NumberOne + NumberTwo;
            return Json(Result);
        }

        [HttpGet]
        [Route("subtract")]
        public JsonResult<int> Subtract()
        {
            var Result = 0;
            var NumberOne = 2;
            Int32 NumberTwo = 2;
            Result = NumberOne - NumberTwo;
            return Json(Result);
        }

        [HttpGet]
        [Route("multiply")]
        public JsonResult<int> Multiply()
        {
            var Result = 0;
            var NumberOne = 2;
            Int32 NumberTwo = 5;
            Result = NumberOne * NumberTwo;
            return Json(Result);
        }

        [HttpGet]
        [Route("divide")]
        public JsonResult<int> Divide()
        {
            var Result = 0;
            var NumberOne = 2;
            Int32 NumberTwo = 5;
            Result = NumberOne / NumberTwo;
            return Json(Result);
        }

        [HttpGet]
        [Route("mod")]
        public JsonResult<int> Modulus()
        {
            var Result = 0;
            var NumberOne = 2;
            Int32 NumberTwo = 5;
            Result = NumberOne % NumberTwo;
            return Json(Result);
        }

        [HttpGet]
        [Route("whatif")]
        public JsonResult<Int32?> WhatIf()
        {
            Int32? Result = 0;
            Int32? NumberOne = 2;
            Int32? NumberTwo = null;
            if (NumberOne != null || NumberTwo != null)
            {
                Result = NumberOne + NumberTwo;
            }
            return Json(Result);
        }

        [HttpGet]
        [Route("for")]
        public JsonResult<List<Int32?>> For()
        {
            List<Int32?> Results = new List<Int32?>();
            List<Int32?> NumberOne = new List<Int32?>(new Int32?[] { 2, 4, 6 });
            List<Int32?> NumberTwo = new List<Int32?>(new Int32?[] { 1, 3, 5 });
            if (NumberOne != null || NumberTwo != null)
            {
                for (int i = 0; i < NumberOne.Count; i++)
                {
                    var Result = NumberOne[i] + NumberTwo[i];
                    Results.Add(Result);
                }
            }
            return Json(Results);
        }

        [HttpGet]
        [Route("switch")]
        public JsonResult<Int32?> Switch()
        {
            Int32? Result = 0;
            Int32? NumberOne = 0;
            Int32? NumberTwo = 0;
            if (NumberOne != null || NumberTwo != null)
            {
                Color c = (Color)(new Random()).Next(0, 3);
                switch (c)
                {
                    case Color.Red:
                        NumberOne = 1;
                        NumberTwo = 1;
                        break;
                    case Color.Green:
                        NumberOne = 2;
                        NumberTwo = 2;
                        break;
                    case Color.Blue:
                        NumberOne = 3;
                        NumberTwo = 3;
                        break;
                    default:
                        break;
                }

                Result = NumberOne + NumberTwo;
            }
            return Json(Result);
        }

        [HttpGet]
        [Route("while")]
        public JsonResult<Int32> While()
        {
            Int32? Result = 0;
            Int32? NumberOne = 0;
            Int32? NumberTwo = 0;
            var Count = 0;
            
            while (Count < 10)
            {
                NumberOne++;
                NumberTwo++;
                Count++;
            }

            Result = NumberOne + NumberTwo;
      
            return Json(Count);
        }
    }
}
