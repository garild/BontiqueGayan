using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkyReg.Common.Extensions
{
    public static class PrimitiveTypeExtensions
    {
        public static bool HasValue(this string text)
        {
            if (string.IsNullOrEmpty(text) && string.IsNullOrWhiteSpace(text))
                return false;
            return true;
        }

        public static string DefaultValue(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return null;

            return text;
        }

        public static string TrimToLower(this string text)
        {
            return text.ToLower().Trim(); ;
        }

    }
}
