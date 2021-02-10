using System.Web;
using System.Web.Optimization;

namespace Ecommerce
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Est-ce que je laisse ces 2 ci? 
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Bundle for CSS 
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
            "~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrapmin").Include(
            "~/Content/bootstrap.bundle.min.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
            //"~/Content/bootstrap.css",
            "~/css/style.css"));

            bundles.Add(new StyleBundle("~/Content/slick").Include(
            "~/lib/slick/slick.css",
            "~/lib/slick/slick-theme.css"));



            // JavaScript librairies
            bundles.Add(new ScriptBundle("~/bundles/easing").Include(
                     "~/lib/easing/easing.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/slick").Include(
                    "~/lib/slick/slick.min.js"));

            //JavaScript
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                    "~/js/main.js"));
        }
    }
}
