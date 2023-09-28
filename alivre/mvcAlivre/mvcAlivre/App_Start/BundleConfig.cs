using System.Web;
using System.Web.Optimization;

namespace mvcAlivre
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/sbjs").Include(
                       "~/Content/sbadmin/bower_components/metisMenu/dist/metisMenu.min.js",
                       "~/Content/sbadmin/bower_components/raphael/raphael-min.js",
                       "~/Content/sbadmin/bower_components/morrisjs/morris.min.js",
                       "~/Content/sbadmin/js/morris-data.js",
                       "~/Content/sbadmin/dist/js/sb-admin-2.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap_social.css",
                      "~/Content/font-awesome.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/sbcss").Include(
                      "~/Content/sbadmin/bower_components/bootstrap/dist/css/bootstrap.min.css",
                      "~/Content/sbadmin/bower_components/metisMenu/dist/metisMenu.min.css",
                      "~/Content/sbadmin/dist/css/timeline.css",
                      "~/Content/sbadmin/dist/css/sb-admin-2.css",
                      "~/Content/sbadmin/bower_components/morrisjs/morris.css",
                      "~/Content/sbadmin/bower_components/font-awesome/css/font-awesome.min.css"
                ));

        }
    }
}
