using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class LakeException : Exception
    {
        public LakeException(string message) : base(message) { }
    }
    public class InvalidDepthException : LakeException
    {
        public InvalidDepthException() : base("Invalid depth input") { }
    }
    public class InvalidSquareException : LakeException
    {
        public InvalidSquareException() : base("Invalid square input") { }
    }
    public class InvalidAgeException : LakeException
    {
        public InvalidAgeException() : base("Invalid age input") { }
    }
    public class InvalidPollutionException : LakeException
    {
        public InvalidPollutionException() : base("Invalid pollution input") { }
    }

    public class InvalidSmallLakeSquareException : LakeException
    {
        public InvalidSmallLakeSquareException() : base("The lake isn't small") { }
    }

    public class InvalidBigLakeSquareException : LakeException
    {
        public InvalidBigLakeSquareException() : base("The lake isn't big") { }
    }

}
