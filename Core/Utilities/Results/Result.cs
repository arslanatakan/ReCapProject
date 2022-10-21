using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)//Result'ın ctor'una; ama tek param.'lı olan ctor'una
        {                                                         //success'i yolla. (satır 15'e)
            Message = message;  
        }
        //get -> read only'dir ve ctor'da set edilebilir.

        public Result(bool success)
        {
            Success = success;
        }//overloading


        public bool Success { get; }

        public string Message { get; }

    }
}
