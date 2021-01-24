#pragma checksum "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\Home\PopUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaed91f246ca0b2b1acd3731cca5d485529209c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PopUp), @"mvc.1.0.view", @"/Views/Home/PopUp.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaed91f246ca0b2b1acd3731cca5d485529209c3", @"/Views/Home/PopUp.cshtml")]
    public class Views_Home_PopUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\Home\PopUp.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaed91f246ca0b2b1acd3731cca5d485529209c32922", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""initial-scale=1, maximum-scale=1, user-scalable=no"">
    <title>OTOPARK KONUMLARI</title>

    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">

    <script src=""https://code.jquery.com/jquery-3.5.1.min.js"" integrity=""sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0="" crossorigin=""anonymous""></script>

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
    <style>
        html, body, #viewDiv {
            padding: 0;
");
                WriteLiteral(@"            margin: 0;
            height: 100%;
            width: 100%;
        }

        #instruction {
            padding: 15px;
            background: white;
            color: black;
            border: 5px solid gold;
            font-family: sans-serif;
            font-size: 1.2em;
        }
    </style>

    <link rel=""stylesheet"" href=""https://js.arcgis.com/4.11/esri/css/main.css"">
    <script src=""https://js.arcgis.com/4.11/""></script>

    <script>
        require([
            ""esri/tasks/Locator"",
            ""esri/Map"",
            ""esri/views/MapView"",
            ""esri/Graphic""
        ], function (Locator, Map, MapView, Graphic) {

            // Set up a locator task using the world geocoding service
            var locatorTask = new Locator({
                url:
                    ""https://geocode.arcgis.com/arcgis/rest/services/World/GeocodeServer""
            });

            var map = new Map({
                basemap: ""topo-vector""
            })");
                WriteLiteral(@";

            var view = new MapView({
                container: ""viewDiv"",
                map: map,
                center: [28.9795, 41.015137],
                zoom: 13
            });

            view.ui.add(""instruction"", ""bottom-left"");

            var point = {
                type: ""point"",
                longitude: 110.36402943937549,
                latitude: 1.5128959885365645
            };

            var simpleMarkerSymbol = {
                type: ""simple-marker"",
                color: [226, 119, 40],  // orange
                outline: {
                    color: [255, 255, 255], // white
                    width: 1
                }
            };

            fetch(""/Home/RecordsDB"")
                .then((res) => res.json())
                .then((result) => {

                    result.forEach((item) => {

                        let point = {
                            type: ""point"",
                            longitude: item.boylam,
       ");
                WriteLiteral(@"                     latitude: item.enlem
                        };
                        //point.push();
                        //point.push(item.enlem);

                        var pointGraphic = new Graphic({
                            geometry: point,
                            symbol: simpleMarkerSymbol
                        });

                        view.graphics.add(pointGraphic);

                    })


                })




            /*******************************************************************
             * This click event sets generic content on the popup not tied to
             * a layer, graphic, or popupTemplate. The location of the point is
             * used as input to a reverse geocode method and the resulting
             * address is printed to the popup content.
             *******************************************************************/
            view.popup.autoOpenEnabled = false;
            view.on(""click"", function (event)");
                WriteLiteral(@" {

                var lat = Math.round(event.mapPoint.latitude * 1000) / 1000;
                var lon = Math.round(event.mapPoint.longitude * 1000) / 1000;

                $('#recorddetail').modal('show');

            })


        })
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaed91f246ca0b2b1acd3731cca5d485529209c38456", async() => {
                WriteLiteral(@"
    <div id=""viewDiv""></div>

    <!-- The Modal -->
    <div class=""modal"" id=""recorddetail"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">

                <!-- Modal Header -->
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Product Detail</h4>
                    <button type=""button"" id=""kayit"" class=""btn btn-primary"">Kayıt</button>

                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>

                <!-- Modal body -->
                <div class=""modal-body"">
                    <div>
                        <label");
                BeginWriteAttribute("for", " for=\"", 5116, "\"", 5122, 0);
                EndWriteAttribute();
                WriteLiteral(">Street : </label>\r\n                        <input");
                BeginWriteAttribute("for", " for=\"", 5173, "\"", 5179, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"street\" />\r\n\r\n                    </div>\r\n                    <div>\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 5284, "\"", 5290, 0);
                EndWriteAttribute();
                WriteLiteral(">City : </label>\r\n                        <input");
                BeginWriteAttribute("for", " for=\"", 5339, "\"", 5345, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"city\" />\r\n\r\n                    </div>\r\n                    <div>\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 5448, "\"", 5454, 0);
                EndWriteAttribute();
                WriteLiteral(">Region : </label>\r\n                        <input");
                BeginWriteAttribute("for", " for=\"", 5505, "\"", 5511, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"region\" />\r\n\r\n                    </div>\r\n                    <div>\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 5616, "\"", 5622, 0);
                EndWriteAttribute();
                WriteLiteral(">Country : </label>\r\n                        <input");
                BeginWriteAttribute("for", " for=\"", 5674, "\"", 5680, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""country"" />

                    </div>
                </div>

                <!-- Modal footer -->
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                </div>

            </div>
        </div>
    </div>


    <div id=""instruction"">
        Click on the map to retrieve coordinates and address
    </div>

    <script>

        $(""#kayit"").click(function () {

            var record = new Object();
            record.ParkAdi = $(""#parkadi"").val();


            $.ajax({

                type: ""POST"",
                url: ""/RecordSelected/AddRecord"",
                data: record,
                success: function (msg) {
                    alert(msg);
                }
            })

        })
       

    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
