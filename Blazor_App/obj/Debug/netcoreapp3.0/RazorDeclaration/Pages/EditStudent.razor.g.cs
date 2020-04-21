#pragma checksum "C:\Users\Abhishek Srivastava\source\repos\Blazor_App\Pages\EditStudent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b0962fb64d4bb0f5e2a37b53c3c9d4faadd406d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abhishek Srivastava\source\repos\Blazor_App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abhishek Srivastava\source\repos\Blazor_App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abhishek Srivastava\source\repos\Blazor_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abhishek Srivastava\source\repos\Blazor_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abhishek Srivastava\source\repos\Blazor_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abhishek Srivastava\source\repos\Blazor_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abhishek Srivastava\source\repos\Blazor_App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abhishek Srivastava\source\repos\Blazor_App\_Imports.razor"
using Blazor_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abhishek Srivastava\source\repos\Blazor_App\_Imports.razor"
using Blazor_App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abhishek Srivastava\source\repos\Blazor_App\Pages\EditStudent.razor"
using Blazor_App.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditStudent/{PresentID}")]
    public partial class EditStudent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Abhishek Srivastava\source\repos\Blazor_App\Pages\EditStudent.razor"
       
    [Parameter]
    public string PresentID { get; set; }
    Employee_Model.Models.entityModels.TblStudent Stu = new Employee_Model.Models.entityModels.TblStudent();



    protected override async Task OnInitializedAsync()
    {
        Stu = await Task.Run(() => service.GetDetailsByID(Convert.ToInt32(PresentID)));
    }

    protected void Update()
    {
        service.UpdateStudent(Stu);
        navigationManager.NavigateTo("/StudentDetails");
    }
    void Cancel()
    {
        navigationManager.NavigateTo("/StudentDetails");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazor_App.Data.Services.Student service { get; set; }
    }
}
#pragma warning restore 1591
