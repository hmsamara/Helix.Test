using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Test.Feature.Navigation
{
    using Sitecore.Data;
    public class Templates
    {
        public struct NavigationItem
        {
            public static readonly ID ID = new ID("{DD6B3A58-7D6F-43D8-89EB-B128459539A5}");
            public struct Fields
            {
                public static readonly ID Title = new ID("{DC1C0E8E-4382-421F-A750-3CCA76ADE5F5}");
                public static readonly ID Destination = new ID("{9205C2AD-E007-4852-A45D-366CE6D33D1E}");
           
            }
        }
    }
}