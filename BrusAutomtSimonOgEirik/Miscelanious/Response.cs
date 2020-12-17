using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class Response
    {
        public string Message;
        public bool IsSuccess;

        public Response(string message, bool isSuccess)
        {
            Message = message;
            IsSuccess = isSuccess;
        }
    }
}
