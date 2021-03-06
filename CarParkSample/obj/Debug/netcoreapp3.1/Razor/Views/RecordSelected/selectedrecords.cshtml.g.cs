#pragma checksum "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c59e6aad03f526d13d12f78a2a5ca011ca2163c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RecordSelected_selectedrecords), @"mvc.1.0.view", @"/Views/RecordSelected/selectedrecords.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c59e6aad03f526d13d12f78a2a5ca011ca2163c", @"/Views/RecordSelected/selectedrecords.cshtml")]
    public class Views_RecordSelected_selectedrecords : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CarParkSample.Models.VM.RecordDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
  
    ViewData["Title"] = "selectedrecords";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"



<title>RecordList</title>
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css""
      integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">

<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.23/css/dataTables.bootstrap4.min.css"" />
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/responsive/2.2.7/css/responsive.bootstrap4.min.css"" />

<script src=""https://code.jquery.com/jquery-3.5.1.min.js"" integrity=""sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0="" crossorigin=""anonymous""></script>
<script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.23/js/jquery.dataTables.min.js""></script>
<script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.23/js/dataTables.bootstrap4.min.js""></script>
<script type=""text/javascript"" src=""https://cdn.datatables.net/responsive/2.2.7/js/dataTables.responsive.min.js""></script>
<script typ");
            WriteLiteral(@"e=""text/javascript"" src=""https://cdn.datatables.net/responsive/2.2.7/js/responsive.bootstrap4.min.js""></script>





<div class=""card"">

    <div class=""card-header"">
        <h3 class=""card-title"">Seçilen Otoparklar</h3>
    </div>

    <div class=""card-body"">
        <table id=""example"" class=""table table-bordered"" style=""width:100%"">
            <thead>
                <tr>
                    <th>_id</th>
                    <th>Park ID</th>
                    <th>Park Adi</th>
                    <th>Lokasyon ID</th>
                    <th>Lokasyon Kodu</th>
                    <th>Lokasyon Adi</th>
                    <th>Park Tipi ID</th>
                    <th>Park Tipi</th>
                    <th>Park Kapasitesi</th>
                    <th>Calisma Saatleri</th>
                    <th>Bolge ID</th>
                    <th>Bolge</th>
                    <th>Alt Bolge ID</th>
                    <th>Alt Bolge</th>
                    <th>Ilce ID</th>
                ");
            WriteLiteral(@"    <th>Ilce</th>
                    <th>Adres</th>
                    <th>Enlem/Boylam</th>
                    <th>Polygon Verisi</th>
                    <th>Boylam</th>
                    <th>Enlem</th>
                    <th>Aylik Abonelik Ucreti</th>
                    <th>Ucretsiz Parklanma Suresi(dakika)</th>
                    <th>Tarifesi</th>
                    <th>Park Et Devam Et Noktası</th>
                    <th>İşlemler</th>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 70 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 73 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item._id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 74 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.ParkID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 75 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.ParkAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 76 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.LokasyonID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 77 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.LokasyonKodu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 78 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.LokasyonAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 79 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.ParkTipiID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 80 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.ParkTipi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 81 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.ParkKapasitesi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 82 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.CalismaSaatleri);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 83 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.BolgeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 84 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.Bolge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 85 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.AltBolgeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 86 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.AltBolge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 87 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.IlceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 88 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.Ilce);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 89 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 90 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.Enlem_Boylam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 91 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.Polygon_Verisi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 92 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.Boylam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 93 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.Enlem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 94 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.Aylik_Abonelik_Ucreti);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 95 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.Ucretsiz_Parklanma_Suresi_dakika);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 96 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.Tarifesi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 97 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                       Write(item.Park_Et_Devam_Et_Noktasi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td>\r\n                            \r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4204, "\"", 4241, 2);
            WriteAttributeValue("", 4211, "/RecordSelected/Edit/", 4211, 21, true);
#nullable restore
#line 101 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
WriteAttributeValue("", 4232, item._id, 4232, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" role=\"button\">Edit</a>\r\n                            <button");
            BeginWriteAttribute("id", " id=\"", 4326, "\"", 4340, 1);
#nullable restore
#line 102 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
WriteAttributeValue("", 4331, item._id, 4331, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger delete\" type=\"submit\">Delete</button>\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 106 "C:\Users\Ece\source\repos\CarParkSample\CarParkSample\Views\RecordSelected\selectedrecords.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </tbody>


        </table>
    </div>

</div>



<script>

    $(function () {
        $(""#example"").DataTable({
            ""responsive"": true, ""lengthChange"": true, ""autoWidth"": true,
        })

    });

   

    $(document).on(""click"", "".delete"", function () {
        let id = $(this).attr(""id"");
        $.ajax({
            url: ""/RecordSelected/Delete"",
            type: ""POST"",
            data: { id: id },
            success: function (msg) {
                console.log(msg);
                $(""#"" + id).fadeOut();
                window.location.href = ""/RecordSelected/selectedrecords""
                alert(""Silme işlemi gerçekleştirildi!!"");
            },
            error: function (err) {
                alert(""Başarısız!"");
            }
        })
    });
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CarParkSample.Models.VM.RecordDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
