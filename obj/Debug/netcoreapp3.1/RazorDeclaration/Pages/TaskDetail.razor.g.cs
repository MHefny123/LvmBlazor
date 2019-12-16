#pragma checksum "/home/mhefny/HefnyWork/BlazorLVM/Pages/TaskDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db7e127974d97fcfdf1fb99d7db0c89b27a06b03"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorLVM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using BlazorLVM;

#line default
#line hidden
#line 9 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using BlazorLVM.Shared;

#line default
#line hidden
#line 4 "/home/mhefny/HefnyWork/BlazorLVM/Pages/TaskDetail.razor"
using BlazorLVM.Data;

#line default
#line hidden
#line 5 "/home/mhefny/HefnyWork/BlazorLVM/Pages/TaskDetail.razor"
using BlazorLVM.Services;

#line default
#line hidden
    public partial class TaskDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 59 "/home/mhefny/HefnyWork/BlazorLVM/Pages/TaskDetail.razor"
       
    [Parameter]
    public BlazorLVM.Models.ToDo TaskObject { get; set; }

    List<string> TaskStatusList = new List<string>() { "New", "In Progress", "Completed" };

    [Parameter]
    public Action DataChanged { get; set; }


    [Parameter]
    public RenderFragment customHeader { get; set; }




    private async Task CloseTaskModal()
    {
        await jsRuntime.InvokeAsync<object>("CloseModal", "taskModal");
    }


    private async void HandleValidSubmit()
    {
        //await service.Add(TaskObject);
        //await CloseTaskModal();
        //DataChanged?.Invoke();
        if (TaskObject.Id == 0)
        {
            await service.Add(TaskObject);
        }
        else
        {
            await service.Update(TaskObject);
        }
        await CloseTaskModal();
        DataChanged?.Invoke();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ToDoListService service { get; set; }
    }
}
#pragma warning restore 1591