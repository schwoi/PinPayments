using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Web;
using System.Runtime.Serialization;

namespace PinPayments
{
    internal static class ParameterBuilder
    {
       public static string ApplyAllParameters(object obj, string url)
        {
            if (obj == null) return url;

            var newUrl = url;

            foreach (var property in obj.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
            {
               
                var attribs = property.GetCustomAttributes(false);
                var ignoreCase = attribs.Any(a => a.GetType().Equals(typeof(IgnoreDataMemberName)));
                var isDataMember = attribs.Any(a => a.GetType().Equals(typeof(DataMemberAttribute)));
                
                if (isDataMember && ignoreCase)
                {
                    var value = property.GetValue(obj, null);

                    if (value != null)
                    {
                        newUrl = ApplyParameterToUrl(newUrl, property.Name, value.ToString());
                    }
                }
                if (isDataMember && !ignoreCase)
                {
                    var JsonPropertyAttribute = (DataMemberAttribute)attribs.FirstOrDefault(a => a.GetType().Equals(typeof(DataMemberAttribute)));

                    var value = property.GetValue(obj, null);

                    if (value != null)
                    {
                        newUrl = ApplyParameterToUrl(newUrl, JsonPropertyAttribute.Name, value.ToString());
                    }
                }
            }

            if (url == "") // othewise it adds a "?" at the start...
            {
                newUrl = newUrl.Substring(1, newUrl.Length - 1);
            }
            return newUrl;
        }


        public static string ApplyParameterToUrl(string url, string argument, string value)
        {
            var token = "&";

            if (!url.Contains("?"))
            {
                token = "?";
            }
            return string.Format("{0}{1}{2}={3}", url, token, argument, HttpUtility.UrlEncode(value));
        }
    }
}
