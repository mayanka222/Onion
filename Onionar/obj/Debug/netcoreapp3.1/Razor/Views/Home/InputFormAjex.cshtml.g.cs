#pragma checksum "C:\Users\mayanka\Desktop\Pratice\Onion\Onionar\Views\Home\InputFormAjex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91790c787c8bdc9920efff6e61ee3e14e6eb43df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InputFormAjex), @"mvc.1.0.view", @"/Views/Home/InputFormAjex.cshtml")]
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
#nullable restore
#line 1 "C:\Users\mayanka\Desktop\Pratice\Onion\Onionar\Views\_ViewImports.cshtml"
using Onionar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mayanka\Desktop\Pratice\Onion\Onionar\Views\_ViewImports.cshtml"
using Onionar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91790c787c8bdc9920efff6e61ee3e14e6eb43df", @"/Views/Home/InputFormAjex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b23f2cf9b84a899005b78d59e46b06ac0b0a128", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_InputFormAjex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mayanka\Desktop\Pratice\Onion\Onionar\Views\Home\InputFormAjex.cshtml"
  
    ViewData["Title"] = "InputFormAjex";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>InputForm ajex </h1>

<div>
    <div class=""row"">

        <div class=""cols-sm-6"">
            Name   <input type=""text"" id=""name"" name=""name"" />
        </div>
        <div class=""cols-sm-6"">
            Coures   <input type=""text"" id=""Coures"" name=""Coures"" />
        </div>
        <div class=""cols-sm-6"">
            Batch    <input type=""text"" id=""Batch"" name=""Batch"" />
        </div>
        <div class=""cols-sm-6"">
            Roll No    <input type=""text"" id=""RollNo"" name=""RollNo"" />
        </div>
        <div class=""cols-sm-6"">
            <button onclick=""Addstudent();"">click me </button>
        </div> 
        <div class=""cols-sm-6"">
            <button onclick=""clicklist();"">click List </button>
        </div>
    </div>
</div>
<div style=""width: 500px"">
    <table id=""tblCustomers"" cellpadding=""0"" cellspacing=""0"" border=""1"" style=""border-collapse:collapse"">
        <thead>
            <tr>
                <th>Customer Id</th>
                <th>Name</th>
     ");
            WriteLiteral(@"           <th>City</th>
                <th>Country</th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
</div>

<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>
<script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>
<link href=""https://cdn.datatables.net/1.10.20/css/jquery.dataTables.css"" rel=""stylesheet"" type=""text/css"" />

<script type=""text/javascript"">
    function Addstudent() {
        debugger;
        var Obj = {
            Name: $('#name').val(),
            Coures: $('#Coures').val(),
            Batch: $('#Batch').val(),
            RollNo: $('#RollNo').val()
        };
        $.ajax({
            url: ""/Home/InputFormDeatilsAjex"",
            data: { model: Obj },
            type: ""POST"",
            success: function (result) {
                console.log(result);
            },
            error: function (errormessage) {
");
            WriteLiteral(@"                alert(errormessage.responseText);
            }
        });
    }
    function clicklist()
    {
        $.ajax({
            type: ""POST"",
            url: ""/Home/Getlist"",
            data: '{}',
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (result) {
             /*   console.log(result);*/
                OnSuccess(result);
            },
            failure: function (response) {
                console.log(onsus)
                alert(response.d);
            },
            error: function (response) {
                alert(response.d);
            }
        });
    }



    function OnSuccess(result) {
        console.log(""data"");
        console.log(result);
        $(""#tblCustomers"").DataTable(
            {
                bLengthChange: true,
                lengthMenu: [[5, 10, -1], [5, 10, ""All""]],
                bFilter: true,
                bSort: true,
             ");
            WriteLiteral(@"   bPaginate: true,
                data: result,
                columns: [{ 'result': 'Id' },
                    { 'result': 'Name' },
                    { 'result': 'Coures' },
                    { 'result': 'RollNo' }]
            });
    };
</script>");
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
