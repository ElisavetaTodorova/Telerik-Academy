using System;
using System.Text.RegularExpressions;

namespace _12.ParseURL
{
    class Startup
    {
        static void Main()
        {
            var url = Console.ReadLine();
            var pattern ="://";

            var protocolSplit = Regex.Split(url, pattern);
            var protocol = protocolSplit[0];
            var rest = protocolSplit[1];

            var indexOfSlash = rest.IndexOf("/");
            var server = rest.Substring(0, indexOfSlash);
            var resource = rest.Substring(indexOfSlash);

            Console.WriteLine("[protocol] = " + protocol);
            Console.WriteLine("[server] = " + server);
            Console.WriteLine("[resource] = " + resource);
        }
    }
}
