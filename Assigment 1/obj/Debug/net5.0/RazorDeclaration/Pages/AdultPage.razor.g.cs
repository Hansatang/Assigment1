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
#line 5 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AdultPage.razor"
using Assigment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AdultPage.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AdultPage.razor"
           [Authorize(Policy = "SecurityLevel4")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AdultPage")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/AdultPage/{Id:int}")]
    public partial class AdultPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\AdultPage.razor"
       
    string mainClass { get; set; }
    string secondaryClass { get; set; }
    
    public Adult Adult { get; set; }

    [Parameter]
    public int Id { get; set; }

    [CascadingParameter]
    protected Task<AuthenticationState> AuthStat { get; set; }

    protected override async Task OnInitializedAsync()
    {
        secondaryClass = "hidden";
        mainClass = "";
        {
            IList<Adult> Adults = await CloudAdultInterface.GetAdultAsync();
            Adult = Adults.First(p => p.Id == Id);
            if (Check(Adult.JobTitle.JobTitle))
            {
                Job job = new Job
                {
                    JobTitle = "Unemployed",
                    Salary = 0
                };
                Adult.JobTitle = job;
            }
        }
    }

    public async void Edit()
    {
        await CloudAdultInterface.UpdateAsync(Adult);
        NavigationManager.NavigateTo("/fetchdata");
    }


    private void Remove()
    {
        if (!mainClass.Equals("hidden"))
        {
            secondaryClass = "";
            mainClass = "hidden";
        }
        else
        {
            secondaryClass = "hidden";
            mainClass = "";
        }
    }

    private async void Confirm()
    {
        await CloudAdultInterface.RemoveAdultAsync(Adult.Id);
        mainClass = "";
        NavigationManager.NavigateTo("/fetchdata");
    }

    public bool Check(string s)
    {
        return string.IsNullOrEmpty(s) ? true : false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudAdultInterface CloudAdultInterface { get; set; }
    }
}
#pragma warning restore 1591
