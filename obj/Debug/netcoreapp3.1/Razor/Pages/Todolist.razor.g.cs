#pragma checksum "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8f3bfb88dffdbbf7d1807b36f2a7cbf88ddae2b"
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
#line 1 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using BlazorLVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/mhefny/HefnyWork/BlazorLVM/_Imports.razor"
using BlazorLVM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
using BlazorLVM.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
using BlazorLVM.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
using BlazorLVM.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
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
            __builder.AddMarkupContent(0, "<h1>To Do List</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from Database.</p>\r\n\r\n");
#nullable restore
#line 19 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
 if (toDoList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 22 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Task</th>\r\n                <th>Status</th>\r\n                <th>Due Date</th>\r\n                <th>Edit</th>\r\n                <th>Delete</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 36 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
             foreach (var toDoItem in toDoList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 39 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
                         toDoItem.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 40 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
                         toDoItem.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 41 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
                         toDoItem.DueDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "btn btn-primary");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
                                                                               (() => PrepareForEdit(toDoItem))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "data-toggle", "modal");
            __builder.AddAttribute(29, "data-target", "#taskModal");
            __builder.AddAttribute(30, "value", "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "class", "btn btn-danger");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
                                                                              (() => PrepareForDelete(toDoItem))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "data-toggle", "modal");
            __builder.AddAttribute(38, "data-target", "#confirmDeleteModal");
            __builder.AddAttribute(39, "value", "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 47 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 50 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "<div>\r\n    <input type=\"button\" data-toggle=\"modal\" data-target=\"#taskModal\" class=\"btn btn-primary\" value=\"Add Task\">\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<BlazorLVM.Pages.ConfirmDialog>(46);
            __builder.AddAttribute(47, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
                         Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.OpenComponent<BlazorLVM.Pages.TaskDetail>(49);
            __builder.AddAttribute(50, "TaskObject", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorLVM.Models.ToDo>(
#nullable restore
#line 60 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
                       taskObject

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "DataChanged", new System.Action(
#nullable restore
#line 60 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
                                                DataChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "customHeader", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(53, 
#nullable restore
#line 61 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
                   customHeader

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "/home/mhefny/HefnyWork/BlazorLVM/Pages/Todolist.razor"
       
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