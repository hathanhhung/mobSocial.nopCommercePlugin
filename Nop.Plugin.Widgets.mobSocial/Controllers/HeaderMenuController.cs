﻿using System.Web.Mvc;
using Nop.Web.Controllers;

namespace Nop.Plugin.Widgets.MobSocial.Controllers
{
    public class HeaderMenuController : MobSocialWidgetBaseController
    {

        [ChildActionOnly]
        public ActionResult PublicInfo(string widgetZone)
        {
            return View("mobSocial/HeaderMenu/PublicInfo");
        }

    }
}
