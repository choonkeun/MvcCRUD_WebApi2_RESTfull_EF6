﻿using System.Web;
using System.Web.Mvc;

namespace BL_WebApi2_WS_EF6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
