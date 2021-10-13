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
#line 3 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FamilyData.razor"
using Assigment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FamilyData.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FamilyData.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FamilyData.razor"
using ChartJs.Blazor.PieChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FamilyData.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FamilyData.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FamilyData")]
    public partial class FamilyData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FamilyData.razor"
 
    [CascadingParameter]
    protected Task<AuthenticationState> AuthStat { get; set; }

    
    public string SearchPhrase { get; set; }
    private int? _width = 600;
    private PieConfig _config;
    
    public IList<Family> Families { get; set; }
    public IList<Family> FamiliesShown { get; set; }

    protected override async Task OnInitializedAsync()
    {
        base.OnInitialized();
        var user = (await AuthStat).User;
        if (!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo($"/Login");
        }
        else
        {
       //     Families = FamilyService.FamilyList;
       //     Families = await cloudFamilyInterface.GetTodosAsync();
            Console.WriteLine(Families.Count);
            FamiliesShown = Families;
        }
    }

    private void NavigateToComponent(Family p)
    {
        NavigationManager.NavigateTo("FamilyPage/" + p.Id);
    }

    private void Search()
    {
        FamiliesShown = new List<Family>();
        foreach (Family family in Families)
        {
            // if (Fa.FirstName.Contains(SearchPhrase) || adult.LastName.Contains(SearchPhrase))
            // {
            //     FamiliesShown.Add(adult);
            // }
        }
        SearchPhrase = "";
        _config.Data.Datasets.Clear();
    }
    
    private void Backer()
    {
        FamiliesShown = Families;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudAdultInterface cloudFamilyInterface { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
