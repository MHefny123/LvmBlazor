#pragma checksum "/home/mhefny/HefnyWork/LvmBlazor/Pages/ConfirmDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14b95f2f41b9e45a9652ce7c18e163f624892549"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorLVM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/mhefny/HefnyWork/LvmBlazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/mhefny/HefnyWork/LvmBlazor/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/mhefny/HefnyWork/LvmBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/mhefny/HefnyWork/LvmBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/mhefny/HefnyWork/LvmBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/mhefny/HefnyWork/LvmBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/mhefny/HefnyWork/LvmBlazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/mhefny/HefnyWork/LvmBlazor/_Imports.razor"
using BlazorLVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/mhefny/HefnyWork/LvmBlazor/_Imports.razor"
using BlazorLVM.Shared;

#line default
#line hidden
#nullable disable
    public partial class ConfirmDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal");
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "id", "confirmDeleteModal");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.AddAttribute(8, "role", "document");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, @"<div class=""modal-header"">
                <h5 class=""modal-title"">Confirmation</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            ");
            __builder.AddMarkupContent(14, "<div class=\"modal-body\">\r\n                <p>Do you want to delete the record?</p>\r\n            </div>\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "modal-footer");
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "btn btn-primary");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "/home/mhefny/HefnyWork/LvmBlazor/Pages/ConfirmDialog.razor"
                                                                        OnClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.AddMarkupContent(24, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cancel</button>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "/home/mhefny/HefnyWork/LvmBlazor/Pages/ConfirmDialog.razor"
       
    [Parameter]
    public int Id { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
