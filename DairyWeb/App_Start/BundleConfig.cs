using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DairyWeb.App_Start
{
    using System.Web.Optimization;

    /// <summary>
    /// This class handles bundle configuration.
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        /// Registers bundles with the application.
        /// </summary>
        /// <param name="bundles">The bundles to register.</param>
        public static void RegisterBundles(BundleCollection bundles)
        {


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

        }
    }
}