#pragma checksum "D:\Applications\C#\My Applications\Backend\BlazorUI\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf17461f70b5059acf8307b57f33c6b62e52ca8e"
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
#line 1 "D:\Applications\C#\My Applications\Backend\BlazorUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Applications\C#\My Applications\Backend\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\Applications\C#\My Applications\Backend\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\Applications\C#\My Applications\Backend\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\Applications\C#\My Applications\Backend\BlazorUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\Applications\C#\My Applications\Backend\BlazorUI\_Imports.razor"
using BlazorUI;

#line default
#line hidden
#line 7 "D:\Applications\C#\My Applications\Backend\BlazorUI\_Imports.razor"
using BlazorUI.Shared;

#line default
#line hidden
#line 2 "D:\Applications\C#\My Applications\Backend\BlazorUI\Pages\Login.razor"
using BlazorUI.Services;

#line default
#line hidden
#line 3 "D:\Applications\C#\My Applications\Backend\BlazorUI\Pages\Login.razor"
using BlazorUI.Models;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 7 "D:\Applications\C#\My Applications\Backend\BlazorUI\Pages\Login.razor"
                  loginModel

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 7 "D:\Applications\C#\My Applications\Backend\BlazorUI\Pages\Login.razor"
                                              HandleLogin

#line default
#line hidden
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "PlaceHolder", "E-mail");
                __builder2.AddAttribute(11, "Class", "form-control");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 9 "D:\Applications\C#\My Applications\Backend\BlazorUI\Pages\Login.razor"
                                                                           loginModel.Email

#line default
#line hidden
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.Email = __value, loginModel.Email))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "PlaceHolder", "Password");
                __builder2.AddAttribute(22, "type", "password");
                __builder2.AddAttribute(23, "Class", "form-control");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 12 "D:\Applications\C#\My Applications\Backend\BlazorUI\Pages\Login.razor"
                                                                                             loginModel.Password

#line default
#line hidden
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginModel.Password = __value, loginModel.Password))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginModel.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.AddMarkupContent(29, "<button class=\"btn btn-primary\" type=\"submit\">Login</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 17 "D:\Applications\C#\My Applications\Backend\BlazorUI\Pages\Login.razor"
       
    LoginModel loginModel = new LoginModel();

    private async Task HandleLogin()
    {
        await AuthService.Login(loginModel);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
    }
}
#pragma warning restore 1591
