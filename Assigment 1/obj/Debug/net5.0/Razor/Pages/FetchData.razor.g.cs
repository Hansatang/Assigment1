#pragma checksum "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "445ccd1bee4fa5a013b156a6bc04952d6625db30"
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
#line 3 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
using Assigment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
using ChartJs.Blazor.PieChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Adults List</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "block_container");
            __builder.AddMarkupContent(3, "<label for=\"search\">Name To search:</label><br>\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                                                         (e) => { SearchPhrase = (string) e.Value; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                               SearchPhrase

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchPhrase = __value, SearchPhrase));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "<br>\r\n    ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "submit");
            __builder.AddAttribute(12, "value", "Search");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                                                  Search

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "submit");
            __builder.AddAttribute(17, "value", "Show All");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                                                    Backer

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "style", "display:flex; flex-direction: row; justify-content: center; align-items: center");
            __builder.OpenComponent<ChartJs.Blazor.Chart>(22);
            __builder.AddAttribute(23, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 20 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                  _width

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.Common.ConfigBase>(
#nullable restore
#line 20 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                                  _config

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
 if (AdultsShown == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<p><em>Loading...</em></p>");
#nullable restore
#line 28 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "table");
            __builder.AddAttribute(27, "class", "table");
            __builder.AddAttribute(28, "id", "datatable");
            __builder.AddMarkupContent(29, @"<thead><tr><th>FirstName</th>
            <th>LastName</th>
            <th>HairColor</th>
            <th>EyeColor</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>
            <th>JobTitle</th></tr></thead>
        ");
            __builder.OpenElement(30, "tbody");
#nullable restore
#line 46 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
         foreach (var adult in AdultsShown)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "tr");
            __builder.AddAttribute(32, "class", "onHoverChange");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                                                  () => NavigateToComponent(adult)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 49 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                     adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 50 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                     adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 51 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                     adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 52 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                     adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 53 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                     adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 54 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                     adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 55 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                     adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 56 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                     adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 57 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
                     adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\krzys\RiderProjects\Assigment 1\Assigment 1\Pages\FetchData.razor"
 
    [CascadingParameter]
    protected Task<AuthenticationState> AuthStat { get; set; }


    public string SearchPhrase { get; set; }
    private int? _width = 600;
    private PieConfig _config;

    public IList<Adult> Adults { get; set; }
    public IList<Adult> AdultsShown { get; set; }

    protected override async Task OnInitializedAsync()
    {
       base.OnInitialized();
        var user = (await AuthStat).User;
        CreatePie();
       if (!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo($"/Login");
        }
        else
        {
            Adults = await CloudAdultInterface.GetAdultAsync();

            AdultsShown = Adults;
            PopulatePie();
        }
    }

    private void NavigateToComponent(Adult p)
    {
        NavigationManager.NavigateTo("AdultPage/" + p.Id);
    }

    private void Search()
    {
        AdultsShown = new List<Adult>();
        foreach (Adult adult in Adults)
        {
            if (adult.FirstName.Contains(SearchPhrase) || adult.LastName.Contains(SearchPhrase))
            {
                AdultsShown.Add(adult);
            }
        }
        SearchPhrase = "";
        _config.Data.Datasets.Clear();
        PopulatePie();
    }

    private void CreatePie()
    {
        _config = new PieConfig
        {
            Options = new PieOptions
            {
                Responsive = false,
                Title = new OptionsTitle
                {
                    Display = true,
                    Text = "Male to Female Ratio"
                }
            }
        };

        foreach (string color in new[] {"Male", "Female"})
        {
            _config.Data.Labels.Add(color);
        }
    }

    private void PopulatePie()
    {
        int male = 0;
        int female = 0;
        foreach (var adult in AdultsShown)
        {
            if (adult.Sex.Equals("M"))
            {
                male += 1;
            }
            else
            {
                female += 1;
            }
        }

        PieDataset<int> dataset = new PieDataset<int>(new[] {male, female})
        {
            BackgroundColor = new[]
            {
                ColorUtil.ColorHexString(255, 99, 132),
                ColorUtil.ColorHexString(255, 205, 86),
            }
        };
        _config.Data.Datasets.Add(dataset);
    }

    private void Backer()
    {
        AdultsShown = Adults;
        _config.Data.Datasets.Clear();
        PopulatePie();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudAdultInterface CloudAdultInterface { get; set; }
    }
}
#pragma warning restore 1591
