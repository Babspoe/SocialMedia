using System.Drawing;
using System.IO;

namespace SocialMedia___Sociout
{
    public static class StaticFunctions
    {
        public static Image ByteArrayToImage(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
