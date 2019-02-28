//-----------------------------------------------------------------------
// <copyright file="BundleConfig.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary
{
    using System.Web;
    using System.Web.Optimization;

    /// <summary>
    /// Initializes a new instance of the BundleConfig class.
    /// </summary>
    /// <param name="bundles">bundles value</param>
    public class BundleConfig
    {
        /// <summary>
        /// use to register bundles
        /// </summary>
        /// <param name="bundles">bundles value</param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = false;
            ////JS
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jQuery.unobtrusive*",
                        "~/Scripts/Validators.js"));

            bundles.Add(new ScriptBundle("~/bundles/highcharts").Include(
                       "~/Scripts/highcharts.js"));

            bundles.Add(new ScriptBundle("~/bundles/customgradientchart").Include(
                       "~/Scripts/custom-gradient-chart.js"));

            ////"~/Scripts/jQuery.unobtrusive.min.js*",
            bundles.Add(new ScriptBundle("~/bundles/foolproof").Include(
                         "~/Scripts/Foolproof/mvcfoolproof.unobtrusive.min.js",
                         "~/Scripts/Foolproof/MvcFoolproofJQueryValidation.min.js"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                            "~/Scripts/Tether.min.js",
                            "~/Scripts/bootstrap.js",
                            "~/Scripts/vendors/bootstrap-select.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatable").Include(
                          "~/Scripts/jquery.dataTables.js",
                          "~/Scripts/dataTables.bootstrap4.js"));

            bundles.Add(new ScriptBundle("~/bundles/Vendor").Include(
                      "~/Scripts/vendors/moment/moment.js",
                      "~/Scripts/vendors/moment/locale/ar-ae.js",
                      "~/Scripts/vendors/moment/locale/en-us.js",
                      "~/Scripts/vendors/jquery.nicescroll.min.js",
                      "~/Scripts/vendors/toastr.js",
                      "~/Scripts/vendors/pickmeup.js",
                      "~/Scripts/vendors/bootbox.min.js",
                      "~/Scripts/jquery.dataTables.js",
                      "~/Scripts/bootstrap-datetimepicker.js",
                      "~/Scripts/dataTables.bootstrap4.min.js",
                      "~/Scripts/vendors/general.js",
                      "~/Scripts/Common.js",
                      "~/Scripts/vendors/Pace/pace.js"));

            ////JS

            ////CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/custom.css",
                     "~/Content/toastr.css",
                     "~/Content/pickmeup.css",
                     "~/Content/owl.carousel.min.css",
                     "~/Content/Pace/templates/pace-theme-flash.tmpl.css",
                     "~/Content/Pace/themes/blue/pace-theme-flash.css",
                     "~/Content/bootstrap-datetimepicker.css",
                     "~/Content/style.css",
                     "~/Content/dev-style.css",
                     "~/Content/highcharts.css"));

            bundles.Add(new StyleBundle("~/Content/datatable").Include(
                   "~/Content/Datatables/dataTables.bootstrap.css"));
            ////CSS
        }
    }
}