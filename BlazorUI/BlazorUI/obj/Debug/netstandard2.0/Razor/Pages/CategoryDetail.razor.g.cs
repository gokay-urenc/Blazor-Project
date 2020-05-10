#pragma checksum "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\Pages\CategoryDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f4717639cc359f5ebdc0c0f3efb6ad1b4fe3a8c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\_Imports.razor"
using BlazorUI;

#line default
#line hidden
#line 7 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\_Imports.razor"
using BlazorUI.Shared;

#line default
#line hidden
#line 2 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\Pages\CategoryDetail.razor"
using BlazorUI.Models;

#line default
#line hidden
#line 3 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\Pages\CategoryDetail.razor"
using BlazorUI.Services;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/categorydetail/{categoryid:int}")]
    public partial class CategoryDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 8 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\Pages\CategoryDetail.razor"
 if (category != null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-md-4");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "h3");
            __builder.AddAttribute(5, "class", "text-info mb-4");
            __builder.AddContent(6, "Category Detail for ");
            __builder.OpenElement(7, "strong");
            __builder.AddContent(8, 
#line 11 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\Pages\CategoryDetail.razor"
                                                                category.CategoryName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 12 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\Pages\CategoryDetail.razor"
                          category

#line default
#line hidden
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 12 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\Pages\CategoryDetail.razor"
                                                    HandleSave

#line default
#line hidden
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "PlaceHolder", "Category Name");
                __builder2.AddAttribute(22, "Class", "form-control");
                __builder2.AddAttribute(23, "Id", "categoryName");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 16 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\Pages\CategoryDetail.razor"
                                                                                                            category.CategoryName

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => category.CategoryName = __value, category.CategoryName))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => category.CategoryName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                ");
                __Blazor.BlazorUI.Pages.CategoryDetail.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#line 17 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\Pages\CategoryDetail.razor"
                                          () => category.CategoryName

#line default
#line hidden
                );
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.AddMarkupContent(32, "<button class=\"button-update\" type=\"submit\">Save</button>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#line 22 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\Pages\CategoryDetail.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 24 "D:\Applications\C#\Web Applications\Blazor\Blazor_2_Project\BlazorUI\BlazorUI\Pages\CategoryDetail.razor"
       
    [Parameter]
    public int CategoryId { get; set; }

    CategoryViewModel category;

    protected override async Task OnInitializedAsync()
    {
        category = await CategoryService.GetCategoryById(CategoryId);
    }

    private void HandleSave()
    {
        CategoryService.Save(category);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
namespace __Blazor.BlazorUI.Pages.CategoryDetail
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591