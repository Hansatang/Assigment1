#pragma checksum "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b925e4e00443963d7469872fd4102b9df52777f"
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
#line 3 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
using Assigment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
           [Authorize(Policy = "SecurityLevel2")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddNew")]
    public partial class AddNew : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddNew</h3>\r\n");
            __builder.AddMarkupContent(1, "<head><link rel=\"stylesheet\" href=\"css/custom/customCss.css\"></head>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container p-3 my-3");
            __builder.AddMarkupContent(4, "<h1>Add New Adult</h1>\r\n    ");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, 
#nullable restore
#line 17 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
        ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form__group field");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "class", "form__field");
            __builder.AddAttribute(13, "placeholder", "fName");
            __builder.AddAttribute(14, "name", "fname");
            __builder.AddAttribute(15, "id", "fname");
            __builder.AddAttribute(16, "required");
            __builder.AddAttribute(17, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                                                   (e) => { FirstName = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                            FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FirstName = __value, FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.AddMarkupContent(21, "<label for=\"fname\" class=\"form__label\">First name:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form__group field");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "class", "form__field");
            __builder.AddAttribute(28, "placeholder", "lName");
            __builder.AddAttribute(29, "name", "lname");
            __builder.AddAttribute(30, "id", "lname");
            __builder.AddAttribute(31, "required");
            __builder.AddAttribute(32, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                                                  (e) => { LastName = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                            LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => LastName = __value, LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.AddMarkupContent(36, "<label for=\"lname\" class=\"form__label\">Last name:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form__group field");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "text");
            __builder.AddAttribute(42, "class", "form__field");
            __builder.AddAttribute(43, "placeholder", "hairColour");
            __builder.AddAttribute(44, "name", "hairColour");
            __builder.AddAttribute(45, "id", "hairColour");
            __builder.AddAttribute(46, "required");
            __builder.AddAttribute(47, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                                                                  (e) => { HairColor = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                                           HairColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HairColor = __value, HairColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.AddMarkupContent(51, "<label for=\"hairColour\" class=\"form__label\">Hair colour:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form__group field");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "type", "text");
            __builder.AddAttribute(57, "class", "form__field");
            __builder.AddAttribute(58, "placeholder", "eyeColour");
            __builder.AddAttribute(59, "name", "eyeColour");
            __builder.AddAttribute(60, "id", "eyeColour");
            __builder.AddAttribute(61, "required");
            __builder.AddAttribute(62, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                                                              (e) => { EyeColor = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                                        EyeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EyeColor = __value, EyeColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.AddMarkupContent(66, "<label for=\"eyeColour\" class=\"form__label\">Eye colour:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "form__group field");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "type", "text");
            __builder.AddAttribute(72, "class", "form__field");
            __builder.AddAttribute(73, "placeholder", "age");
            __builder.AddAttribute(74, "name", "age");
            __builder.AddAttribute(75, "id", "age");
            __builder.AddAttribute(76, "required");
            __builder.AddAttribute(77, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                                       (e) => { Age = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                      Age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Age = __value, Age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.AddMarkupContent(81, "<label for=\"age\" class=\"form__label\">Age:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "form__group field");
            __builder.OpenElement(85, "input");
            __builder.AddAttribute(86, "type", "text");
            __builder.AddAttribute(87, "class", "form__field");
            __builder.AddAttribute(88, "placeholder", "weight");
            __builder.AddAttribute(89, "name", "weight");
            __builder.AddAttribute(90, "id", "weight");
            __builder.AddAttribute(91, "required");
            __builder.AddAttribute(92, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                                                   (e) => { Weight = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                               Weight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Weight = __value, Weight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.AddMarkupContent(96, "<label for=\"weight\" class=\"form__label\">Weight:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "form__group field");
            __builder.OpenElement(100, "input");
            __builder.AddAttribute(101, "type", "text");
            __builder.AddAttribute(102, "class", "form__field");
            __builder.AddAttribute(103, "placeholder", "height");
            __builder.AddAttribute(104, "name", "height");
            __builder.AddAttribute(105, "id", "height");
            __builder.AddAttribute(106, "required");
            __builder.AddAttribute(107, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                                                   (e) => { Height = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                               Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Height = __value, Height));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n        ");
            __builder.AddMarkupContent(111, "<label for=\"height\" class=\"form__label\">Height:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n    ");
            __builder.OpenElement(113, "div");
            __builder.AddAttribute(114, "class", "form__group field");
            __builder.OpenElement(115, "input");
            __builder.AddAttribute(116, "type", "text");
            __builder.AddAttribute(117, "class", "form__field");
            __builder.AddAttribute(118, "placeholder", "sex");
            __builder.AddAttribute(119, "name", "sex");
            __builder.AddAttribute(120, "id", "sex");
            __builder.AddAttribute(121, "required");
            __builder.AddAttribute(122, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                                       (e) => { Sex = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(123, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                      Sex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Sex = __value, Sex));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n        ");
            __builder.AddMarkupContent(126, "<label for=\"sex\" class=\"form__label\">Sex:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n    ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "form__group field");
            __builder.OpenElement(130, "input");
            __builder.AddAttribute(131, "type", "text");
            __builder.AddAttribute(132, "class", "form__field");
            __builder.AddAttribute(133, "placeholder", "jobTitle");
            __builder.AddAttribute(134, "name", "jobTitle");
            __builder.AddAttribute(135, "id", "jobTitle");
            __builder.AddAttribute(136, "required");
            __builder.AddAttribute(137, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                                                           (e) => { JobTitle = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(138, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                                     JobTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(139, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => JobTitle = __value, JobTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n        ");
            __builder.AddMarkupContent(141, "<label for=\"jobTitle\" class=\"form__label\">Job title:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n    ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "form__group field");
            __builder.OpenElement(145, "input");
            __builder.AddAttribute(146, "type", "text");
            __builder.AddAttribute(147, "class", "form__field");
            __builder.AddAttribute(148, "placeholder", "salary");
            __builder.AddAttribute(149, "name", "salary");
            __builder.AddAttribute(150, "id", "salary");
            __builder.AddAttribute(151, "required");
            __builder.AddAttribute(152, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                                                   (e) => { Salary = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(153, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                                                               Salary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(154, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Salary = __value, Salary));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n        ");
            __builder.AddMarkupContent(156, "<label for=\"salary\" class=\"form__label\">Salary:</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n    ");
            __builder.OpenElement(158, "div");
            __builder.AddAttribute(159, "class", "wrap");
            __builder.OpenElement(160, "input");
            __builder.AddAttribute(161, "id", "submitButton");
            __builder.AddAttribute(162, "type", "submit");
            __builder.AddAttribute(163, "value", "Submit");
            __builder.AddAttribute(164, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
                                                                        Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
       
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
        Adults =  await CloudAdultInterface.GetAdultAsync();
       
    }

    public async void Edit()
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
            
            await CloudAdultInterface.AddAdultAsync(adult);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudAdultInterface CloudAdultInterface { get; set; }
    }
}
#pragma warning restore 1591
