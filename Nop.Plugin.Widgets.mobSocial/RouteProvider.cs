﻿using System.Web.Mvc;
using System.Web.Routing;
using Nop.Web.Framework.Localization;
using Nop.Web.Framework.Mvc.Routes;
using Nop.Web.Framework.Seo;

namespace Nop.Plugin.Widgets.MobSocial
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {

            // redirects to your store
            routes.MapRoute("FacebookWebsiteApp",
                 "FacebookWebsiteApp",
                 new { controller = "FacebookWebsiteApp", action = "Index" },
                 new[] { "Nop.Plugin.Widgets.mobSocial.Controllers" }
           );


            routes.MapRoute("GetCustomerProfile",
                  "MobSocial/GetCustomerProfile/{customerId}",
                  new { controller = "mobSocial", action = "GetCustomerProfile" },
                  new[] { "Nop.Plugin.Widgets.mobSocial.Controllers" }
            );

            routes.MapLocalizedRoute("PopulateUrlSlugs",
                            "MobSocial/PopulateUrlSlugs",
                            new { controller = "mobSocial", action = "PopulateUrlSlugs" },
                            new[] { "Nop.Plugin.Widgets.mobSocial.Controllers" });


            routes.MapLocalizedRoute("Plugin.Widgets.mobSocial.Configure",
                 "Plugins/mobSocial/Configure",
                 new { controller = "mobSocial", action = "Configure" },
                 new[] { "Nop.Plugin.Widgets.mobSocial.Controllers" }
            );

            routes.MapLocalizedRoute("Plugin.Widgets.mobSocial.PublicInfo",
                 "Plugins/mobSocial/PublicInfo",
                 new { controller = "mobSocial", action = "PublicInfo" },
                 new[] { "Nop.Plugin.Widgets.mobSocial.Controllers" }
            );


            



            routes.MapLocalizedRoute("TeamPage",
                  "Team/{teamId}",
                  new { controller = "mobSocial", action = "Team" },
                  new[] { "Nop.Plugin.Widgets.mobSocial.Controllers" }
            );

            routes.MapLocalizedRoute("AddFriend",
                  "MobSocial/AddFriend/{toCustomerId}",
                  new { controller = "mobSocial", action = "AddFriend" },
                  new[] { "Nop.Plugin.Widgets.mobSocial.Controllers" }
            );

            routes.MapLocalizedRoute("FriendRequests",
                  "MobSocial/FriendRequests",
                  new { controller = "mobSocial", action = "FriendRequests" },
                  new[] { "Nop.Plugin.Widgets.mobSocial.Controllers" }
            );

            routes.MapLocalizedRoute("ConfirmFriend",
                "MobSocial/ConfirmFriend/{friendCustomerId}",
                new { controller = "mobSocial", action = "ConfirmFriend" },
                new[] { "Nop.Plugin.Widgets.mobSocial.Controllers" }
            );


            routes.MapLocalizedRoute("PeopleSearchAutoComplete",
                            "MobSocial/SearchTermAutoComplete",
                            new { controller = "mobSocial", action = "SearchTermAutoComplete" },
                            new[] { "Nop.Plugin.Widgets.mobSocial.Controllers" });


            routes.MapLocalizedRoute("EventPageSearchAutoComplete",
                            "EventPage/EventPageSearchAutoComplete",
                            new { controller = "EventPage", action = "EventPageSearchAutoComplete" },
                            new[] { "Nop.Plugin.Widgets.mobSocial.Controllers" });

            routes.MapLocalizedRoute("BusinessPageSearchAutoComplete",
                           "BusinessPage/BusinessPageSearchAutoComplete",
                           new { controller = "BusinessPage", action = "BusinessPageSearchAutoComplete" },
                           new[] { "Nop.Plugin.Widgets.mobSocial.Controllers" });


            // admin routes
            routes.MapRoute("ManageTeamPage",
                  "ManageTeamPage/{action}",
                  new { controller = "TeamPage", action = "Index" },
                  new[] { "Nop.Plugin.Widgets.MobSocial.Admin.Controllers" }
            );

            routes.MapRoute("ManageEventPage",
                  "ManageEventPage/{action}",
                  new { controller = "ManageEventPage", action = "Index" },
                  new[] { "Nop.Plugin.Widgets.MobSocial.Admin.Controllers" }
            );


        }

        public int Priority
        {
            get
            {
                return 100;
            }
        }
    }
}
