using System;
using System.Collections.Generic;

namespace _07.MB.Infrastructure.Context.Web
{
    public interface ICookieHelper
    {
        void AppendCookie(string cookieKey,
            string cookieValue = "",
            bool httpOnly = true,
            string cookiePath = "/",
            bool cookieSecure = false,
            DateTimeOffset cookieExpiretion = default);

        public void AppendCookie<T>(string cookieKey,
            List<T> listCookieValue,
            char listDelimiter,
            bool httpOnly = true,
            string cookiePath = "/",
            bool cookieSecure = false,
            DateTimeOffset cookieExpiretion = default);

        string GetCookieValue(string key);
        List<string> GetCookieValue(string key, char listDelimiter);
        bool HasCookie(string key);
        void Remove(string key);
    }
}
