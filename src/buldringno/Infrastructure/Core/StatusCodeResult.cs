﻿namespace BuldringNo.Infrastructure.Core
{
    public class CodeResultStatus
    {
        private int _status;
        private string _message;

        public int Status {
            get { return _status; }
            private set { }
        }

        public string Message
        {
            get { return _message; }
            private set { }
        }

        public CodeResultStatus(int status)
        {
            if (status == 401)
                _message = "Uautorisert tilgang. Innlogging kreves";

            _status = status;
        }

        public CodeResultStatus(int code, string message)
        {
            _status = code;
            _message = message;
        }
    }
}
