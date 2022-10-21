using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; } //set edilmesini ctor'da yapacağız.
        string Message { get; }

    }
}
