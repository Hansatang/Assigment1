#pragma checksum "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d32d85ddcaffb1068529ed0e2af2e24ec00996e"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\_Imports.razor"
using Assigment_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\_Imports.razor"
using Assigment_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Login.razor"
using Assigment_1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "id", "block_container");
                __builder2.AddMarkupContent(4, "<label>User name:</label>\r\n                ");
                __builder2.OpenElement(5, "input");
                __builder2.AddAttribute(6, "type", "text");
                __builder2.AddAttribute(7, "placeholder", "user name");
                __builder2.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Login.razor"
                                                                        username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n                ");
                __builder2.AddMarkupContent(11, "<label>Password:</label>\r\n                ");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "type", "password");
                __builder2.AddAttribute(14, "placeholder", "password");
                __builder2.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Login.razor"
                                                                           password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "style", "color:red");
                __builder2.AddContent(20, 
#nullable restore
#line 14 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Login.razor"
                                        errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "type", "submit");
                __builder2.AddAttribute(24, "value", "Login");
                __builder2.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Login.razor"
                                                             PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.OpenElement(27, "input");
                __builder2.AddAttribute(28, "type", "submit");
                __builder2.AddAttribute(29, "value", "Register");
                __builder2.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Login.razor"
                                                                PerformRegister

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(31, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "type", "submit");
                __builder2.AddAttribute(34, "value", "Log" + " out," + " " + (
#nullable restore
#line 20 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Login.razor"
                                              context.User.Identity.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Login.razor"
                                                                                    PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Login.razor"
       
    private string username;
    private string password;
    private string errorMessage;


    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("Login");
    }

    private async Task PerformLogin()
    {
        errorMessage = "";
        try
        {
            await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
           // NavigationManager.NavigateTo("/fetchdata");
            username = "";
            password = "";
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

    public async Task PerformLogout()
    {
        errorMessage = "";
        username = "";
        password = "";
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

    private void PerformRegister()
    {
        NavigationManager.NavigateTo("/register");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
