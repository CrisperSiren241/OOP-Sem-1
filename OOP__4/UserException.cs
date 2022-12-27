using System;

namespace OOP__4
{
    class UserException : Exception
    {
        public UserException(string Emessage) : base(Emessage) { }
    }
}
