using dbLibrary;
using System.Drawing;
using System.IO;

namespace SocialMedia___Sociout
{
    public static class StaticFunctions
    {
        static dbFunctions db = new dbFunctions();

        public static Image ByteArrayToImage(byte[] bytes)
        {
            if(bytes != null) 
            {
                using (var ms = new MemoryStream(bytes))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            if(imageIn != null)
            {
                using (var ms = new MemoryStream())
                {
                    imageIn.Save(ms, imageIn.RawFormat);
                    return ms.ToArray();
                }
            }
            else
            {
                return new byte[0];
            }

        }

    }
}
