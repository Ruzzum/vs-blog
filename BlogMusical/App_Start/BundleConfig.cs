using System.Web;
using System.Web.Optimization;

namespace BlogMusical
{
    public class BundleConfig
    {
        
        public static void RegisterBundles(BundleCollection bundles)
        {
            //To Do: Habilitar esta opcion antes de liberar
            //BundleTable.EnableOptimizations = false;

            //CSS
            bundles.Add(new StyleBundle("~/bundles/coreCSS")
                .Include(
                    "~/Content/css/bootstrap.min.css",
                    "~/Content/css/font-awesome.min.css",
                    "~/Content/css/blog-custom.css"
                ));

            //JS
            bundles.Add(new ScriptBundle("~/bundles/coreJS")
                .Include(
                    "~/Content/js/plugins/jquery-3.1.1.min.js",
                    "~/Content/js/plugins/bootstrap.min.js",
                    "~/Content/js/blog-scripts.js"
                ));   
        }

    }
}
