#pragma checksum "/home/mhefny/HefnyWork/LvmBlazor/Pages/Todolist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9959525946bb4f6893648e0f9cafb97f21f5953b"
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
#nullable restore
#line 7 "/home/mhefny/HefnyWork/LvmBlazor/Pages/Todolist.razor"
using BlazorLVM.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/mhefny/HefnyWork/LvmBlazor/Pages/Todolist.razor"
using BlazorLVM.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/mhefny/HefnyWork/LvmBlazor/Pages/Todolist.razor"
using BlazorLVM.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/mhefny/HefnyWork/LvmBlazor/Pages/Todolist.razor"
using BlazorLVM.Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todolist")]
    public partial class Todolist : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "/home/mhefny/HefnyWork/LvmBlazor/Pages/Todolist.razor"
       
    List<BlazorLVM.Models.ToDo> toDoList;
    BlazorLVM.Models.ToDo taskObject = new Models.ToDo();


    string customHeader = "Add New"; // string.Empty;





    protected override async Task OnInitializedAsync()
    {
        toDoList = await service.Get();
    }




    private async void DataChanged()
    {
        toDoList = await service.Get();
        StateHasChanged();
    }




    private void InitializeTaskObject()
    {
        customHeader = "Add New Task";
        taskObject = new BlazorLVM.Models.ToDo();
        taskObject.DueDate = DateTime.Now;

    }

    private void PrepareForEdit(BlazorLVM.Models.ToDo task)
    {
        customHeader = "Edit Task";
        taskObject = task;
    }



    private void PrepareForDelete(BlazorLVM.Models.ToDo task)
    {
        taskObject = task;
    }
    
    private async Task Delete()
    {
        var task = await service.Delete(taskObject.Id);
        await jsRuntime.InvokeAsync<object>("CloseModal", "confirmDeleteModal");
        toDoList = await service.Get();
        taskObject = new BlazorLVM.Models.ToDo();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ToDoListService service { get; set; }
    }
}
#pragma warning restore 1591
