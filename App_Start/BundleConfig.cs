﻿using System.Web;
using System.Web.Optimization;

namespace AttendanceManagement
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/chart.min.js",
                        "~/Scripts/jquery.nicescroll.min.js",
                        "~/Scripts/popper.js",
                        "~/Scripts/sa-functions.js",
                        "~/Scripts/scroll-up-bar.min.js",
                        "~/Scripts/style.js",
                        "~/Scripts/summernote-lite.js",
                        "~/Scripts/tooltip.js",
                        "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.min.css",
                        "~/Content/style.css",
                        "~/Content/fontawesome-all.min.css",
                        "~/Content/bootstrap-icons.css",
                        "~/Content/summernote-lite.css"));
        }
    }
}
