#pragma checksum "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0e3491cd788c3f6135cd14950c605425528deaf"
// <auto-generated/>
#pragma warning disable 1591
namespace Assigment_1.Pages
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
#line 2 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
using Assigment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Add New Adult</h1>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, 
#nullable restore
#line 8 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
    ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, "<label for=\"fname\">First name:</label><br>\r\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                                                  (e) => { FirstName = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                           FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FirstName = __value, FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "<br>\r\n");
            __builder.AddMarkupContent(11, "<label for=\"lname\">Last name:</label><br>\r\n");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                                                 (e) => { LastName = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                           LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LastName = __value, LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "<br>\r\n");
            __builder.AddMarkupContent(18, "<label for=\"lname\">HairColor:</label><br>\r\n");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "text");
            __builder.AddAttribute(21, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                                                  (e) => { HairColor = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                           HairColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HairColor = __value, HairColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "<br>\r\n");
            __builder.AddMarkupContent(25, "<label for=\"lname\">EyeColor:</label><br>\r\n");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "text");
            __builder.AddAttribute(28, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                                                 (e) => { EyeColor = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                           EyeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EyeColor = __value, EyeColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "<br>\r\n");
            __builder.AddMarkupContent(32, "<label for=\"lname\">Age:</label><br>\r\n");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "text");
            __builder.AddAttribute(35, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                                            (e) => { Age = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                           Age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Age = __value, Age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "<br>\r\n");
            __builder.AddMarkupContent(39, "<label for=\"lname\">Weight:</label><br>\r\n");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "text");
            __builder.AddAttribute(42, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                                               (e) => { Weight = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                           Weight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Weight = __value, Weight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "<br>\r\n");
            __builder.AddMarkupContent(46, "<label for=\"lname\">Height:</label><br>\r\n");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "text");
            __builder.AddAttribute(49, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                                               (e) => { Height = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                           Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Height = __value, Height));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "<br>\r\n");
            __builder.AddMarkupContent(53, "<label for=\"lname\">Sex:</label><br>\r\n");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "text");
            __builder.AddAttribute(56, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                                            (e) => { Sex = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                           Sex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Sex = __value, Sex));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "<br>\r\n");
            __builder.AddMarkupContent(60, "<label for=\"lname\">JobTitle:</label><br>\r\n");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "type", "text");
            __builder.AddAttribute(63, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                                                 (e) => { JobTitle = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                           JobTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => JobTitle = __value, JobTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "<br>\r\n");
            __builder.AddMarkupContent(67, "<label for=\"lname\">Salary:</label><br>\r\n");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "text");
            __builder.AddAttribute(70, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                                               (e) => { Salary = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                           Salary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Salary = __value, Salary));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "<br>\r\n");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "submit");
            __builder.AddAttribute(76, "value", "Submit");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
                                              Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\Index.razor"
       
    public string ErrorMessage { get; set; }
    public IList<Adult> Adults { get; set; }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Age { get; set; }
    public string Weight { get; set; }
    public string Height { get; set; }
    public string Sex { get; set; }
    public string JobTitle { get; set; }
    public string Salary { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Adults = AdultService.AdultsList;
    }

    public void Edit()
    {
        if (Check(FirstName) || Check(LastName) || Check(Age) || Check(HairColor) || Check(EyeColor) || Check(Weight) || Check(Height))
        {
            ErrorMessage = "Please fill all fields";
        }
        else
        {
            Adult adult = new Adult
            {
                Id = Adults.Count,
                FirstName = FirstName,
                LastName = LastName,
                Age = Int32.Parse(Age),
                Height = Int32.Parse(Height),
                Weight = float.Parse(Weight),
                Sex = Sex,
                EyeColor = EyeColor,
                HairColor = HairColor,
            };
            if (!Check(JobTitle))
            {
                Job job = new Job
                {
                    JobTitle = JobTitle,
                    Salary = Int32.Parse(Salary)
                };
                adult.JobTitle = job;
            }
            else
            {
                Job job = new Job
                {
                    JobTitle = "Unemployed",
                    Salary = 0
                };
                adult.JobTitle = job;
            }

            Adults.Add(adult);
            AdultService.Save();
            NavigationManager.NavigateTo("/fetchdata");
        }
    }

    public bool Check(string s)
    {
        return (s == null || s == String.Empty) ? true : false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591
