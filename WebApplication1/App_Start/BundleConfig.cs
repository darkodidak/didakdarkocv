using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

               bundles.Add(new StyleBundle("~/bundles/css")
                .Include(
                "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                "~/Content/vendor/font-awesome/css/font-awesome.min.css",
                "~/Content/vendor/devicons/css/devicons.min.css",
                "~/Content/vendor/simple-line-icons/css/simple-line-icons.css",
                "~/Content/css/resume.min.css"));


  

               bundles.Add(new ScriptBundle("~/bundles/js")
                .Include(
                "~/Content/vendor/jquery/jquery.min.js",
                "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js",
                "~/Content/vendor/jquery-easing/jquery.easing.min.js",
                "~/Content/js/resume.min.js"));
        }
    }
}