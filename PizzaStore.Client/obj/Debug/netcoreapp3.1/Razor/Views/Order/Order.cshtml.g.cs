#pragma checksum "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c72a09f20c389795ff1756c64b63458777856db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Order), @"mvc.1.0.view", @"/Views/Order/Order.cshtml")]
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
#line 1 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/_ViewImports.cshtml"
using PizzaStore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/_ViewImports.cshtml"
using PizzaStore.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c72a09f20c389795ff1756c64b63458777856db", @"/Views/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76f8687bb5e0029a0daac9a35609a03e346eee80", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaStore.Client.Models.PizzaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/order/placeorder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c72a09f20c389795ff1756c64b63458777856db4056", async() => {
                WriteLiteral("\n\n");
#nullable restore
#line 6 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
   foreach (var crust in @Model.Crusts)
  {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <input type=\"radio\" name=\"crust\" id=\"crust\"");
                BeginWriteAttribute("value", " value=\"", 203, "\"", 222, 1);
#nullable restore
#line 8 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
WriteAttributeValue("", 211, crust.Name, 211, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-val=\"true\" data-val-required=\"Needed\">\n    <label for=\"crust\">");
#nullable restore
#line 9 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
                  Write(crust.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n");
#nullable restore
#line 10 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
   
  }

#line default
#line hidden
#nullable disable
                WriteLiteral("  <p>\n  ");
#nullable restore
#line 13 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
Write(Html.ValidationMessageFor(m => m.Crust));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n  </p>\n  \n\n  <p></p>\n\n  <select name=\"size\"");
                BeginWriteAttribute("id", " id=\"", 411, "\"", 416, 0);
                EndWriteAttribute();
                WriteLiteral(">\n");
#nullable restore
#line 20 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
     foreach (var size in @Model.Sizes)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c72a09f20c389795ff1756c64b63458777856db6288", async() => {
#nullable restore
#line 22 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
                            Write(size.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
         WriteLiteral(size.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 23 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("  <p>\n  ");
#nullable restore
#line 25 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
Write(Html.ValidationMessageFor(m => m.Size));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n  </p>\n  </select>\n  \n  <p></p>\n\n");
#nullable restore
#line 31 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
   foreach (var topping in @Model.Toppings)
  {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <input type=\"checkbox\" name=\"selectedtoppings\" id=\"selectedtoppings\"");
                BeginWriteAttribute("value", " value=\"", 725, "\"", 746, 1);
#nullable restore
#line 33 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
WriteAttributeValue("", 733, topping.Name, 733, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    <label for=\"selectedtoppings\">");
#nullable restore
#line 34 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
                             Write(topping.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n");
#nullable restore
#line 35 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
    
  }

#line default
#line hidden
#nullable disable
                WriteLiteral("  <p>\n  ");
#nullable restore
#line 38 "/home/ethan/revanture/week_4/training-code-week3/PizzaStore/PizzaStore.Client/Views/Order/Order.cshtml"
Write(Html.ValidationMessageFor(m => m.SelectedToppings));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n  </p>\n  <p></p>\n\n  <input type=\"submit\" value=\"place order\">\n  <!--<button type=\"submit\">testing</button>    It doesn\'t look like I need both this line and the line above this -->\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            WriteLiteral("\n");
            WriteLiteral("<a href=\"/user/index\">user homepage</a>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaStore.Client.Models.PizzaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
