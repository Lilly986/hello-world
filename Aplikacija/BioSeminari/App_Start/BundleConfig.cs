﻿using System.Web.Optimization;

namespace MSDNRoles
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

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/jquery-1.10.2.js",
                      "~/Scripts/jquery.validate.min.js",
                      "~/Scripts/jquery.validate.unobtrusive.min.js",
                      "~/Scripts/jquery-ui.js",
                      "~/Scripts/jquery-ui-datepicker-hr.js",
                      "~/Scripts/moment.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-overrides.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/font-awesome.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/materialdesignicons.min.css",
                      "~/Content/jquery.mCustomScrollbar.min.css",
                      "~/Content/prettyPhoto.css",
                      "~/Content/unslider.css",
                      "~/Content/template.css",
                      "~/Content/site.css"));
        }
    }
}