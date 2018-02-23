using System;
using System.Text;

namespace My2Gov.Proxy
{
    internal static class DomainConfig
    {
         
        private const string UserName = "azizs";
        private const string Password = "aBAlGjE9VbNyWQh#B@qoXag2V$#uLoB0";
        public const string EndPoint = "https://my2.gov.uz";
        public readonly static string Credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(UserName + ":" + Password));

    }
}
