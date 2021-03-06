#pragma checksum "C:\Users\kouge\source\repos\Blazor\RadzenTreeDemo\RadzenTreeDemo\Pages\TreeDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ceaaf0a43399041830c2517e43ba3262377e3604"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RadzenTreeDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kouge\source\repos\Blazor\RadzenTreeDemo\RadzenTreeDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kouge\source\repos\Blazor\RadzenTreeDemo\RadzenTreeDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kouge\source\repos\Blazor\RadzenTreeDemo\RadzenTreeDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kouge\source\repos\Blazor\RadzenTreeDemo\RadzenTreeDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kouge\source\repos\Blazor\RadzenTreeDemo\RadzenTreeDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kouge\source\repos\Blazor\RadzenTreeDemo\RadzenTreeDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kouge\source\repos\Blazor\RadzenTreeDemo\RadzenTreeDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kouge\source\repos\Blazor\RadzenTreeDemo\RadzenTreeDemo\_Imports.razor"
using RadzenTreeDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kouge\source\repos\Blazor\RadzenTreeDemo\RadzenTreeDemo\_Imports.razor"
using RadzenTreeDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kouge\source\repos\Blazor\RadzenTreeDemo\RadzenTreeDemo\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kouge\source\repos\Blazor\RadzenTreeDemo\RadzenTreeDemo\Pages\TreeDemo.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kouge\source\repos\Blazor\RadzenTreeDemo\RadzenTreeDemo\Pages\TreeDemo.razor"
using RadzenTreeDemo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kouge\source\repos\Blazor\RadzenTreeDemo\RadzenTreeDemo\Pages\TreeDemo.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tree")]
    public partial class TreeDemo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\kouge\source\repos\Blazor\RadzenTreeDemo\RadzenTreeDemo\Pages\TreeDemo.razor"
       
    Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();
    IEnumerable<string> entries = null;

    void Log(string eventName, string value)
    {
        events.Add(DateTime.Now, $"{eventName}:{value}");
    }

    void LogChange(TreeEventArgs args)
    {
        Log("Change", $"Item Text:{args.Text}");
    }

    void LogExpand(TreeExpandEventArgs args)
    {
        if (args.Value is string text)
        {
            Log("Expand", $"Text:{text}");
        }
    }

    IEnumerable<Category> categories;
    protected override async Task OnInitializedAsync()
    {
        categories = await Task.Run(() => productService.CategoryList() );
    }

    //For Directory Browsing
    protected override void OnInitialized()
    {
        entries = Directory.GetDirectories(HostEnvironment.ContentRootPath)
            .Where(entry => {
                var name = Path.GetFileName(entry);
                return !name.StartsWith(".") && name != "bin" && name != "obj";
            });
    }

    void LoadFiles(TreeExpandEventArgs args)
    {
        var directory = args.Value as string;
        args.Children.Data = Directory.EnumerateFileSystemEntries(directory);
        args.Children.Text = GetTextForNode;
        args.Children.HasChildren = (path) => Directory.Exists((string)path);

        Log("Expand", $"Text:{args.Text}");
    }

    string GetTextForNode(object data)
    {
        return Path.GetFileName((string)data);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostEnvironment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductService productService { get; set; }
    }
}
#pragma warning restore 1591
