using System.Web;
using System.Web.Optimization;

namespace PCArchitect
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles( BundleCollection bundles )
        {
            bundles.Add( new ScriptBundle( "~/bundles/external" ).Include(
                         /* JQuery */
                         EScript( "jquery-3.1.1" ),
                         EScript( "jquery.validate" ),
                         EScript( "jquery.validate.unobtrusive" ),

                         EScript( "bootstrap" ) ) );

            //bundles.Add( new ScriptBundle( "~/bundles/pc-architect" ).Include(
            //             PcaScript( "" ) ) );

            bundles.Add( new StyleBundle( "~/bundles/css" ).Include(
                         CSS( "bootstrap" ),
                         CSS( "site" ) ) );
        }

        /// <summary>
        /// Generates the full location of the external script to be included.
        /// </summary>
        /// <param name="scriptName">The name of the script to include, do not include the file type.</param>
        /// <returns>The virtual location of the external script.</returns>
        private static string EScript( string scriptName )
        {
            return "~/content/scripts/external/" + scriptName + ".js";
        }

        /// <summary>
        /// Generates the full location of the PC Architect script to be included.
        /// </summary>
        /// <param name="scriptName">The name of the script to include, do not include the file type.</param>
        /// <returns>The virtual location of the PC Architect script.</returns>
        private static string PcaScript( string scriptName )
        {
            return "~/content/scripts/pca/" + scriptName + ".js";
        }

        /// <summary>
        /// Generates the full location of the CSS to be included.
        /// </summary>
        /// <param name="fileName">The name of the style to include, do not include the file type.</param>
        /// <returns>The virtual location of the CSS file.</returns>
        private static string CSS( string fileName )
        {
            return "~/content/css/" + fileName + ".css";
        }
    }
}
