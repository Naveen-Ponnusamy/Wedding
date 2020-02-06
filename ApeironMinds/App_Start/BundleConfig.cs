using System.Web;
using System.Web.Optimization;

namespace ApeironMinds
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

            bundles.Add(new ScriptBundle("~/js").Include(
                      "~/js/bootstrap.min.js",
                      "~/js/classie.js,",
                      "~/js/isotope.min.js",
                      "~/js/jquery-ui.min.js",
                      "~/js/jqurey.validate.js",
                      "~/js/lightcase.js",
                      "~/js/liveloader.js",
                      "~/js/owl.carousel.min.js",
                      "~/js/script.js",
                      "~/js/scroll-animate.js",
                      "~/js/selectFx.js",
                      "~/js/slippry.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/css").Include(
                      "~/css/animate.min.css",
                      "~/css/style.css",
                      "~/css/bootstrap.min.css",
                      "~/css/cs-select.css",
                      "~/css/cs-skin-elastic.css",
                      "~/css/font-awesome.min.css",
                      "~/css/lightcase.css",
                      "~/css/owl.carousel.css",
                      "~/css/resposive.css",
                      "~/css/slippry.css"));
        }
    }
}
