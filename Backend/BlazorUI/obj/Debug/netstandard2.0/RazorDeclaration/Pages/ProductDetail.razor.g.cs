#pragma checksum "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\Backend\BlazorUI\Pages\ProductDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea713e9224b5652fe011fff81d0d85bfd1915317"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\Backend\BlazorUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\Backend\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\Backend\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\Backend\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\Backend\BlazorUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\Backend\BlazorUI\_Imports.razor"
using BlazorUI;

#line default
#line hidden
#line 7 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\Backend\BlazorUI\_Imports.razor"
using BlazorUI.Shared;

#line default
#line hidden
#line 2 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\Backend\BlazorUI\Pages\ProductDetail.razor"
using BlazorUI.Models;

#line default
#line hidden
#line 3 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\Backend\BlazorUI\Pages\ProductDetail.razor"
using BlazorUI.Services;

#line default
#line hidden
#line 4 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\Backend\BlazorUI\Pages\ProductDetail.razor"
using BlazorUI.Utilities;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/productdetail/{productid:int}")]
    public partial class ProductDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 46 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\Backend\BlazorUI\Pages\ProductDetail.razor"
       
    [Parameter]
    public int ProductId { get; set; }

    ProductViewModel product;
    CategoryListViewModel[] categories;

    protected override async Task OnInitializedAsync()
    {
        product = await ProductService.GetProductById(ProductId);
        categories = await CategoryService.GetCategories();
    }

    private void HandleSave()
    {
        ProductService.Save(product);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
