using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Test.Feature.Content
{
    using Sitecore.Data;
    public class Templates
    {
        public struct BaseData
        {
            public static readonly ID ID = new ID("{937C70BF-9079-4E40-9B26-40EFA244BF0E}");
            public struct Fields
            {
                public static readonly ID Title = new ID("{781E9ACF-2F70-493C-BF12-55C66EA84181}");
                public static readonly ID Description = new ID("{DE1F2951-6D67-4A37-A2BA-38E0543158FF}");

            }
        }
        public struct FooterData
        {
            public static readonly ID ID = new ID("{CDF24D63-3CF5-4A18-BCBE-8E857C124A92}");
            public struct Fields
            {
                public static readonly ID Copyrights = new ID("{03083B23-88CE-4BF7-BC9C-EA76EAB68199}");
                
            }
        }
        public struct HeaderData
        {
            public static readonly ID ID = new ID("{DA8A60CB-EE1D-418C-A2DA-3F4CA44826B2}");
            public struct Fields
            {
                public static readonly ID Logo = new ID("{9E6838DC-F900-43A9-8851-95D94081DF0E}");
                public static readonly ID Title = new ID("{5D832F00-4B5B-42CB-B135-72C5FE8F80CC}");

            }
        }
        public struct InnerPage
        {
            public static readonly ID ID = new ID("{1A15445F-3804-4D38-812E-9F7997360F89}");
            public struct Fields
            {
                public static readonly ID Thumbnail = new ID("{0DCC5DAB-AA58-4BA8-BF0B-CC948C7616C8}");
                public static readonly ID Link = new ID("{35803177-459D-4A12-A99C-D588A21B0053}");
                public static readonly ID Type = new ID("{AB58EEA5-715C-4A29-9AA8-FE034BC038D0}");

            }
        }
        public struct Type
        {
            public static readonly ID ID = new ID("{F5523506-B08E-4D39-B77F-50970E63901C}");
            public struct Fields
            {
                public static readonly ID Name = new ID("{074A02AE-46A3-4C1B-9937-60CF414B228F}");
                public static readonly ID Value = new ID("{E488804F-272C-4F0C-9FD8-9E14060FD85C}");

            }
        }
    }
}
