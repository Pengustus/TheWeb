using System;
using System.Collections.Generic;
using System.Text;

namespace WebServer.Server.HTTP_Request
{
    public class HeaderCollection
    {
        private readonly Dictionary<string, Header> headers;
        public HeaderCollection()
        {
            headers = new Dictionary<string, Header>();
        }

        public int Count => this.headers.Count;
        public void Add(string name, string value)
        {
            var headers = new Header(name, value);
            this.headers.Add(name, headers);
        }
    }
}
