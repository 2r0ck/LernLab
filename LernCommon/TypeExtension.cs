using Newtonsoft.Json;
using System;

namespace LernCommon
{
    public static class TypeExtension
    {
        public static string TypeToString<T>(this T target) where T : class => JsonConvert.SerializeObject(target);
    }
}
