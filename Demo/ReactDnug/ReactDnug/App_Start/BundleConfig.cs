using System.Web;
using System.Web.Optimization;
using System.Web.Optimization.React;

namespace ReactDnug.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new JsxBundle("~/bundles/main").Include(
                "~/Scripts/Tutorial.jsx",
                "~/Scripts/showdown.js"
            ));

            // Forces files to be combined and minified in debug mode
            // Only used here to demonstrate how combination/minification works
            // Normally you would use unminified versions in debug mode.
            BundleTable.EnableOptimizations = true;
        }
    }
}