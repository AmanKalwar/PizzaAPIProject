#pragma checksum "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Pizza\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12e019fa98af32e31cd05b82bd777593e8a6f8bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Index), @"mvc.1.0.view", @"/Views/Pizza/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\_ViewImports.cshtml"
using PizzaHut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\_ViewImports.cshtml"
using PizzaHut.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12e019fa98af32e31cd05b82bd777593e8a6f8bd", @"/Views/Pizza/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e37da2dc4f4f9368457193c61a97d84750b0e1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<PizzaHut.Models.PizzaDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-image:url(\'/images/bg_4.jpg\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12e019fa98af32e31cd05b82bd777593e8a6f8bd3716", async() => {
                WriteLiteral("\n");
                WriteLiteral(@"    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
    <style>
        
            .jumbotron-fluid {
            display: flex;
            flex-direction: row;
            flex-wrap: wrap;
            width: 100%;
            justify-content: center;
        }

        .card #body {
            overflow: hidden;
        }

        .card {
            background-color: black;
            display: flex;
            flex-direction: row;
            mar");
                WriteLiteral(@"gin: 10px;
        }

            .card .extra {
                padding: 10px;
                color: white;
            }

            .card #body img {
                transition: 0.5s ease-in;
            }


            .card #body:hover img {
                transform: scale(1.2);
            }
        .btn {
            background-color: none;
            color: aqua;
            border: 2px solid #1efffe;
            transition: 0.5s ease-in-out;
            border-radius: 20px;
            font-weight: bold;
        }
       /* .btn {
            width: 100px;
           
           
           
           
          
            margin-left: 50px;
        }
*/
            .btn:hover {
                color: white;
                box-shadow: 0 0 20px 0 #1efffe;
                background: linear-gradient(to right top, #d16ba5, #c777b9, #ba83ca, #aa8fd8, #9a9ae1, #8aa7ec, #79b3f4, #69bff8, #52cffe, #41dfff, #46eefa, #5ffbf1);
            }
    </style>
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12e019fa98af32e31cd05b82bd777593e8a6f8bd6770", async() => {
                WriteLiteral("\n  \n\n");
#nullable restore
#line 88 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Pizza\Index.cshtml"
     if (TempData.Peek("UserID") != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\n        <br />\n        <br />\n        <br />\n        <h3 style=\"color:aqua\"> ");
#nullable restore
#line 94 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Pizza\Index.cshtml"
                           Write(TempData.Peek("UserName"));

#line default
#line hidden
#nullable disable
                WriteLiteral("!!!!</h3>\n        <h5 style=\"color:aqua\">Please select the Pizza</h5>\n        <div class=\"jumbotron-fluid\">\n");
#nullable restore
#line 97 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Pizza\Index.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"card\" style=\"height:250px;width:400px\">\n                    <div id=\"body\" style=\" height:250px;width:200px;\">\n                        <img");
                BeginWriteAttribute("src", " src=", 2921, "", 2938, 1);
#nullable restore
#line 102 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 2926, item.Images, 2926, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"no image\" style=\"width:200px; height:250px;\">\n                    </div>\n                    <div class=\"extra\" style=\"width:200px;\">\n                        <p style=\"font-weight: bold; color: aqua\">");
#nullable restore
#line 105 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Pizza\Index.cshtml"
                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n\n                        <p style=\"font-size: 15px; font-family: \'Times New Roman\', Times, serif; color: aqua \">");
#nullable restore
#line 107 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Pizza\Index.cshtml"
                                                                                                          Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n\n                        <p style=\"color: aqua\">\n                            $ ");
#nullable restore
#line 110 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Pizza\Index.cshtml"
                         Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <a");
                BeginWriteAttribute("href", " href=\"", 3386, "\"", 3448, 1);
#nullable restore
#line 110 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 3393, Url.Action("GetToppings","Toppings",new {ID=item.ID }), 3393, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""margin-bottom:10px;"">
                               
                            <button type=""button"" class=""btn"" style="" color: aqua;"">
                                    Add to Cart
                                </button>
                            </a>
                        </p>
                    </div>
                </div>
");
#nullable restore
#line 119 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Pizza\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n");
#nullable restore
#line 121 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Pizza\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\n            alert(\"Please login or register\");\n            window.location.href = \"/Users\";\n        </script>\n");
#nullable restore
#line 128 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Pizza\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<PizzaHut.Models.PizzaDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
