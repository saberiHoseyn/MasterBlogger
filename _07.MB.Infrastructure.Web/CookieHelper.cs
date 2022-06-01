using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.MB.Infrastructure.Context.Web
{
    public class CookieHelper : ICookieHelper
    {
        private readonly IHttpContextAccessor Context;

        public CookieHelper(IHttpContextAccessor httpContext)
        {
            Context = httpContext;
        }


        public bool HasCookie(string key)
        {
            return Context.HttpContext.Request.Cookies.ContainsKey(key);
        }

        public string GetCookieValue(string key)
        {
            return Context.HttpContext.Request.Cookies[key];
        }

        public List<string> GetCookieValue(string key, char listDelimiter)
        {
            var cookievalue = GetCookieValue(key);
            return cookievalue.Split(listDelimiter).ToList();
        }


        public void Remove(string key)
        {
            if (Context.HttpContext.Request.Cookies[key] != null)
            {
                Context.HttpContext.Response.Cookies.Delete(key);
            }
        }

        public void AppendCookie(string cookieKey, string cookieValue = "",
            bool httpOnly = true, string cookiePath = "/",
            bool cookieSecure = false, DateTimeOffset cookieExpiretion = default)
        {
            Context.HttpContext.Response.Cookies.Append(cookieKey, cookieValue, new CookieOptions
            {
                HttpOnly = httpOnly,
                Path = cookiePath,
                Secure = (!cookieSecure) ? Context.HttpContext.Request.IsHttps : default,
                Expires = cookieExpiretion
            });
        }


        public void AppendCookie<T>(string cookieKey, List<T> listCookieValue, char listDelimiter,
            bool httpOnly = true, string cookiePath = "/",
            bool cookieSecure = false, DateTimeOffset cookieExpiretion = default)
        {
            string newCookieValue;

            if (listCookieValue.Count == 0)
            {
                newCookieValue = "";
            }
            else
            {
                newCookieValue = string.Join(listDelimiter, listCookieValue);
            }
            AppendCookie(cookieKey, newCookieValue, httpOnly, cookiePath, cookieSecure, cookieExpiretion);
        }
    }
}
