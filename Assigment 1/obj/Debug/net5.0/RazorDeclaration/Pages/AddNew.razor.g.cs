// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AddNew.razor"
       
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
        Console.WriteLine("Add New");
        Adults = await CloudAdultInterface.GetAdultAsync();
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
                    Id= Adults.Count,
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

    public bool Check(string stringToCheck)
    {
        return string.IsNullOrEmpty(stringToCheck) ? true : false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudAdultInterface CloudAdultInterface { get; set; }
    }
}
#pragma warning restore 1591
