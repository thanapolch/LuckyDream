using System.Web;
using System.Web.Optimization;

namespace LuckyDream
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/myStyle.css"));
            
            bundles.Add(new StyleBundle("~/Content/font-awesome").Include(
                      "~/Content/plugins/font-awesome/all.min.css",
                      "~/Content/plugins/font-awesome/brands.min.css",
                      "~/Content/plugins/font-awesome/fontawesome.min.css",
                      "~/Content/plugins/font-awesome/regular.min.css",
                      "~/Content/plugins/font-awesome/solid.min.css",
                      "~/Content/plugins/font-awesome/svg-with-js.min.css",
                      "~/Content/plugins/font-awesome/v4-shims.min.css"
                      ));
            
            bundles.Add(new ScriptBundle("~/bundles/font-awesome").Include(
                        "~/Scripts/plugins/font-awesome/all.min.js",
                        "~/Scripts/plugins/font-awesome/brands.min.js",
                        "~/Scripts/plugins/font-awesome/fontawesome.min.js",
                        "~/Scripts/plugins/font-awesome/regular.min.js",
                        "~/Scripts/plugins/font-awesome/solid.min.js",
                        "~/Scripts/plugins/font-awesome/v4-shims.min.js"
                        ));
        }
    }
}
