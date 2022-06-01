using MB.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MB.Infrastructure.Context.Web
{
    public class UserLikeManager : IUserLikeManager
    {
        private readonly ICookieHelper cookieHelper;
        private const char listDelimiter = ',';
        private const string cookieKeyName = "Like";

        public UserLikeManager(ICookieHelper cookieHelper)
        {
            this.cookieHelper = cookieHelper;
        }

        public bool AddLike(long id)
        {
            if (!cookieHelper.HasCookie(cookieKeyName))
            {
                cookieHelper.AppendCookie(cookieKeyName, id.ToString(),
                                          cookieExpiretion: DateTime.UtcNow.AddYears(100));
                return true;
            }
            else
            {
                var listCookieValue = cookieHelper.GetCookieValue(cookieKeyName, listDelimiter);
                return ToggleLike(id, listCookieValue);
            }
        }

        public bool HasLikeUserAny(long id)
        {
            if (!cookieHelper.HasCookie(cookieKeyName))
            {
                return false;
            }

            var listCookieValue = cookieHelper.GetCookieValue(cookieKeyName, listDelimiter);
            if (listCookieValue.Any(x => x == id.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ToggleLike(long id, List<string> CookieValue)
        {
            bool result;
            if (CookieValue.Any(x => x == id.ToString()))
            {
                CookieValue.Remove(id.ToString());
                result = false;
                cookieHelper.AppendCookie<string>(cookieKeyName, CookieValue, listDelimiter,
                    cookieExpiretion: DateTime.UtcNow.AddYears(100));
            }
            else
            {
                CookieValue.Add(id.ToString());
                result = true;
                cookieHelper.AppendCookie<string>(cookieKeyName, CookieValue, listDelimiter,
                    cookieExpiretion: DateTime.UtcNow.AddYears(100));
            }
            return result;
        }
    }
}
