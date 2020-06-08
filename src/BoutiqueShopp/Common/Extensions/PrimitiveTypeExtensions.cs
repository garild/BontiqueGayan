using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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


        public static byte[] ImageToByte(this Image imageIn)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] imageByte = (byte[])_imageConverter.ConvertTo(imageIn, typeof(byte[]));
            return imageByte;
        }
    }
}
