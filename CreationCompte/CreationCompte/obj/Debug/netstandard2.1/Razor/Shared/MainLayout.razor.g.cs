#pragma checksum "C:\Users\tizia\Source\Repos\LP_Proj_ESC\CreationCompte\CreationCompte\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a71e8b806821f9b1ec3507206990e7c8226b118"
// <auto-generated/>
#pragma warning disable 1591
namespace CreationCompte.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tizia\Source\Repos\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tizia\Source\Repos\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tizia\Source\Repos\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tizia\Source\Repos\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tizia\Source\Repos\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tizia\Source\Repos\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using CreationCompte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tizia\Source\Repos\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using CreationCompte.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tizia\Source\Repos\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tizia\Source\Repos\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tizia\Source\Repos\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tizia\Source\Repos\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tizia\Source\Repos\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\tizia\Source\Repos\LP_Proj_ESC\CreationCompte\CreationCompte\_Imports.razor"
using Utils;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "content px-4");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\tizia\Source\Repos\LP_Proj_ESC\CreationCompte\CreationCompte\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
