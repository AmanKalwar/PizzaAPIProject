#pragma checksum "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c4d4e6c59624af23852348827a9c5eeb2537228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4d4e6c59624af23852348827a9c5eeb2537228", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e37da2dc4f4f9368457193c61a97d84750b0e1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml"
  
    var Orders = (List<OrdersDTO>)ViewData["Orders"];
    var Pizza = (List<PizzaDTO>)ViewData["Pizza"];
    var count = ViewData["count"];
    var sum = ViewData["sum"];



#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c4d4e6c59624af23852348827a9c5eeb25372283647", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>
    <style>

        .card #body {
            overflow: hidden;
        }

        .card {
            background-image: url('/images/bg_1.jpg');
            display: flex;
            margin: 10px;
        }

        body {
            background-image: url('/images/summery1.jpg');
            background-size: cover;
        }

        .btn {
            width: 200px;
            border-radius: 20px;
            color: aqua;
            font-weight: bold;
            border: 2px solid #1efffe;
            transition: 0.5s ease-in-out;
            margin-left: 50px;
        }

            .btn:hover {
                c");
                WriteLiteral(@"olor: white;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c4d4e6c59624af23852348827a9c5eeb25372285934", async() => {
                WriteLiteral("\n");
#nullable restore
#line 54 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml"
    if (TempData["Empty"] == null)
   {



#line default
#line hidden
#nullable disable
                WriteLiteral("    <br />\n    <br />\n    <br />\n    <h3 style=\"color: #1efffe\">HIIIII!  ");
#nullable restore
#line 61 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml"
                                   Write(TempData.Peek("UserName"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h3>\n    <p style=\"color: #1efffe\">This is your order summery----))</p>\n");
                WriteLiteral("    <h5 style=\"color: #1efffe\">The Pizza you are selected are:</h5>\n    <p style=\"color: #1efffe\">_____________________________________________________________</p>\n");
#nullable restore
#line 66 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml"
     foreach (var item in Pizza)
    {


#line default
#line hidden
#nullable disable
                WriteLiteral("        <p style=\"color: #1efffe\">\n            ");
#nullable restore
#line 70 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        </p>\n");
#nullable restore
#line 72 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <p style=\"color: #1efffe\">_____________________________________________________________</p>\n");
                WriteLiteral("    <h6 style=\"color: #1efffe\">\n        Total number of Items you selected:  ");
#nullable restore
#line 76 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml"
                                        Write(count);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <br /><br />\n        Total Price :                        ");
#nullable restore
#line 78 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml"
                                        Write(sum);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <br /><br />\n        Delivery Address:                    ");
#nullable restore
#line 80 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml"
                                        Write(TempData.Peek("Address"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    </h6>\n          <div class=\"form-group\">\n              <a");
                BeginWriteAttribute("href", " href=\"", 2513, "\"", 2549, 1);
#nullable restore
#line 84 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml"
WriteAttributeValue("", 2520, Url.Action("Index", "Pizza"), 2520, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><button class=\"btn\">Thank You</button></a>\n              <a");
                BeginWriteAttribute("href", " href=\"", 2610, "\"", 2646, 1);
#nullable restore
#line 85 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml"
WriteAttributeValue("", 2617, Url.Action("Index", "Users"), 2617, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><button class=\"btn\">Log Out</button></a>\n              \n          </div>\n");
#nullable restore
#line 88 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml"
   }
   else
      {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"         <script>
             $(document).ready(function () {
                 $(""#myModal"").modal();
             });
               
         </script>
                                                <div class=""modal"" id=""myModal"">
                                                    <div class=""modal-dialog"">
                                                        <div class=""modal-content"">

                                                            <div class=""modal-header"">
                                                                <img src=""\images\Pizzahutlogo.JPG"" alt=""image missing"" height=""50"" width=""50""><h4 class=""modal-title"">&nbsp;&nbsp; Pizza Hut </h4>
                                                                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                                                            </div>


                                                            <div class=""modal-body"">
                                                 ");
                WriteLiteral(@"             No Items in the Cart
                                                            </div>


                                                            <div class=""modal-footer"">
                                                                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                                                            </div>

                                                        </div>
                                                    </div>
                                                </div>
                                                <div style=""display:flex;padding:20px;justify-content:center;margin:70px auto"">
                                                    <a");
                BeginWriteAttribute("href", " href=\"", 4532, "\"", 4568, 1);
#nullable restore
#line 120 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml"
WriteAttributeValue("", 4539, Url.Action("Index", "Pizza"), 4539, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><button class=\"btn\">Go Back</button></a>\n                                                    <a");
                BeginWriteAttribute("href", " href=\"", 4665, "\"", 4701, 1);
#nullable restore
#line 121 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml"
WriteAttributeValue("", 4672, Url.Action("Index", "Users"), 4672, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><button class=\"btn\">Log Out</button></a>\n                                                </div>\r\n");
#nullable restore
#line 123 "C:\Users\Administrator\Desktop\PizzaAPI\PizzaConquers\PizzaHut-main\PizzaHut\Views\Orders\Index.cshtml"
                                                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
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
            WriteLiteral("\n    </html>");
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
