using dbLibrary;
using SocialMedia___Sociout.User_Controls;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SocialMedia___Sociout
{
    public static class StaticFunctions
    {
        static dbFunctions db = new dbFunctions();

        public static Image ByteArrayToImage(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

    }
}
