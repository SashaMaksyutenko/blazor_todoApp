// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazor_todo_app
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/sashamaksyutenko/Desktop/C# projects/Blazor_app1/blazor_todo_app/blazor_todo_app/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sashamaksyutenko/Desktop/C# projects/Blazor_app1/blazor_todo_app/blazor_todo_app/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/sashamaksyutenko/Desktop/C# projects/Blazor_app1/blazor_todo_app/blazor_todo_app/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/sashamaksyutenko/Desktop/C# projects/Blazor_app1/blazor_todo_app/blazor_todo_app/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/sashamaksyutenko/Desktop/C# projects/Blazor_app1/blazor_todo_app/blazor_todo_app/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/sashamaksyutenko/Desktop/C# projects/Blazor_app1/blazor_todo_app/blazor_todo_app/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/sashamaksyutenko/Desktop/C# projects/Blazor_app1/blazor_todo_app/blazor_todo_app/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/sashamaksyutenko/Desktop/C# projects/Blazor_app1/blazor_todo_app/blazor_todo_app/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/sashamaksyutenko/Desktop/C# projects/Blazor_app1/blazor_todo_app/blazor_todo_app/_Imports.razor"
using blazor_todo_app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/sashamaksyutenko/Desktop/C# projects/Blazor_app1/blazor_todo_app/blazor_todo_app/_Imports.razor"
using blazor_todo_app.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/sashamaksyutenko/Desktop/C# projects/Blazor_app1/blazor_todo_app/blazor_todo_app/_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "/Users/sashamaksyutenko/Desktop/C# projects/Blazor_app1/blazor_todo_app/blazor_todo_app/Todo.razor"
       
    private IEnumerable<TodoItem> todos = new List<TodoItem>();
    protected override void OnInitialized()
    {
        todos = repository.GetAllItems();
    }

    private string newTodo;
    private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            //todos.Add(new TodoItem { Title = newTodo });
            repository.AddTodo(newTodo);
            newTodo = string.Empty;
        }
    }
    private void DeleteTodo(int id)
    {
        //todos.Remove(deletedItem);
        repository.DeleteItem(id);
    }
    private void StatusChanger(TodoItem changedItem)
    {
        changedItem.IsDone = !changedItem.IsDone;
        repository.ValueChanged(changedItem);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private blazor_todo_app.Data.Repository.IRepository repository { get; set; }
    }
}
#pragma warning restore 1591
