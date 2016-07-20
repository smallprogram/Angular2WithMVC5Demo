using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace AngularJSWithMVC5Demo.App_Start
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            #region CssRewriteUrlTransform
            CssRewriteUrlTransform cssTransformer = new CssRewriteUrlTransform();
            #endregion

            bundles.Add(new ScriptBundle("~/bundles/Angular2").Include(
                "~/node_modules/core-js/client/shim.min.js",
                "~/node_modules/zone.js/dist/zone.js",
                "~/node_modules/reflect-metadata/Reflect.js", 
                "~/node_modules/systemjs/dist/system.src.js", 
                "~/App_Start/Angular2Config/systemjs.config.js"
                ));

            

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/styles.css", cssTransformer)
                );
            
        }
    }
}
