// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace demoHRMS.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HP\source\repos\demoHRMS\demoHRMS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\demoHRMS\demoHRMS\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\source\repos\demoHRMS\demoHRMS\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\source\repos\demoHRMS\demoHRMS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\source\repos\demoHRMS\demoHRMS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\source\repos\demoHRMS\demoHRMS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\source\repos\demoHRMS\demoHRMS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\source\repos\demoHRMS\demoHRMS\_Imports.razor"
using demoHRMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\source\repos\demoHRMS\demoHRMS\_Imports.razor"
using demoHRMS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\demoHRMS\demoHRMS\Pages\Dashboard.razor"
using demoHRMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\source\repos\demoHRMS\demoHRMS\Pages\Dashboard.razor"
using demoHRMS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\source\repos\demoHRMS\demoHRMS\Pages\Dashboard.razor"
using demoHRMS.Business;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dashboard")]
    public partial class Dashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\HP\source\repos\demoHRMS\demoHRMS\Pages\Dashboard.razor"
       

    private List<Employee> employees;
    protected override async Task OnInitializedAsync()
    {
        employees = await service.GetEmployeeList();
    }
    void AddPerson()
    {
        UriHelp.NavigateTo("addPerson", true);
    }

    void DeletePerson()
    {
        service.DeletePerson(selectedPerson);
        UriHelp.NavigateTo("dashboard", true);

    }
    void EditPerson()
    {
        UriHelp.NavigateTo("addPerson", true);
    }

    public Employee selectedPerson { get; set; }

    void ToggleToDo(Employee person)
    {
        selectedPerson = person;
        appstate.employee = person;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelp { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Business.ServicesVM service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Business.AppState appstate { get; set; }
    }
}
#pragma warning restore 1591