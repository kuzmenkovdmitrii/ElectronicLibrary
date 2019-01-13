using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ElLib.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.unobtrusive-ajax.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.unobtrusive.js"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                "~/Scripts/popper.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.bundle.js",
                "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/content/bootstrap").Include(
                "~/Content/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/mdbootstrap").Include(
                "~/Scripts/mdb.js"));

            bundles.Add(new ScriptBundle("~/content/mdbootstrap").Include(
                "~/Content/mdb.css"));

            //bundles.Add(new ScriptBundle("~/content/select2").Include(
            //    "~/Scripts/select2.js"));

            //bundles.Add(new ScriptBundle("~/bundles/select2").Include(
            //    "~/Content/css/select2.css"));

            bundles.Add(new ScriptBundle("~/content/site").Include(
                "~/Content/Application.css",
                "~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/content/icons").Include(
                "~/Content/font-awesome.css"));

            bundles.Add(new ScriptBundle("~/bundles/select2")
                .Include("~/Scripts/select2.js"));

            bundles.Add(new StyleBundle("~/Content/select2")
                .Include("~/Content/select2.css"));
        }
    }
}