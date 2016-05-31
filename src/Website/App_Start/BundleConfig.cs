using System.Web.Optimization;

namespace Website
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/angular-material.css",
                "~/Content/Site.css"));
            bundles.Add(new ScriptBundle("~/Scripts/ng").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-animate.js",
                "~/Scripts/angular-aria.js",
                "~/Scripts/angular-messages.js",
                "~/Scripts/angular-resource.js",
                "~/Scripts/angular-material/angular-material.js"
                ));
            bundles.Add(new ScriptBundle("~/Scripts/app").Include("~/app/*.js"));
        }
    }
}
