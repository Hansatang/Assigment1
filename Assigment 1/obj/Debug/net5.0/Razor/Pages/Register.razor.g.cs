#pragma checksum "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9b61c7c6a00bfddec3e530c4ddc9ca5c8657a1c"
// <auto-generated/>
#pragma warning disable 1591
namespace Assigment_1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
using Assigment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
using System.Collections;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Register</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<label for=\"fname\">Domain:</label><br>\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
                                                    (e) => { User.Domain = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
                           User.Domain

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.Domain = __value, User.Domain));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "<br>\r\n");
            __builder.AddMarkupContent(8, "<label for=\"lname\">Username:</label><br>\r\n");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
                                                      (e) => { User.UserName = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
                           User.UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.UserName = __value, User.UserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "<br>\r\n");
            __builder.AddMarkupContent(15, "<label for=\"lname\">Password:</label><br>\r\n");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
                                                      (e) => { User.Password = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
                           User.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.Password = __value, User.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "<br>\r\n");
            __builder.AddMarkupContent(22, "<label for=\"lname\">Security Level:</label><br>\r\n");
            __builder.OpenElement(23, "select");
            __builder.AddAttribute(24, "class", "selectpicker");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
                                    User.SecurityLevel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.SecurityLevel = __value, User.SecurityLevel));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 19 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
     foreach (var item in SecurityLevels)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "option");
            __builder.AddContent(28, 
#nullable restore
#line 21 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
                  item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n<br>\r\n");
            __builder.AddMarkupContent(30, "<label for=\"lname\">Role:</label><br>\r\n");
            __builder.OpenElement(31, "select");
            __builder.AddAttribute(32, "class", "selectpicker");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
                                    User.Role

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => User.Role = __value, User.Role));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 27 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
     foreach (var item in Roles)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "option");
            __builder.AddContent(36, 
#nullable restore
#line 29 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
                  item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "submit");
            __builder.AddAttribute(40, "value", "Submit");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
                                              Save

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Register.razor"
       

    public ArrayList SecurityLevels = new()
    {
        1, 2, 3, 4, 5
    };

    public ArrayList Roles = new()
    {
        "Student", "Teacher"
    };

    public User User = new();

    private void Save()
    {
        CloudUserService.Save(User);
        // UserService.Save(User);
        NavigationManager.NavigateTo("/Login");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudUserService CloudUserService { get; set; }
    }
}
#pragma warning restore 1591
