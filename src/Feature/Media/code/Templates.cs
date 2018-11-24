using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Test.Feature.Media
{
    using Sitecore.Data;
    public class Templates
    {

        public struct AdTemplate
        {
            public static readonly ID ID = new ID("{16431206-681D-4B29-95A5-1DB16FC00C1D}");
            public struct Fields
            {
                public static readonly ID Image = new ID("{1E489E87-B893-44E0-AB3E-640106083B0B}");
                public static readonly ID Destination = new ID("{DB967B85-6769-4DF8-BE09-6B3C18667D4C}");

            }
        }
        public struct Banner
        {
            public static readonly ID ID = new ID("{67B7B9C5-F9B6-4216-82F9-3C5B0BDE42C4}");
            public struct Fields
            {
                public static readonly ID Banner = new ID("{FDEE4D8E-DCE5-4E83-9219-DC5657E4C88E}");
              

            }
        }
    }
}