#pragma checksum "D:\Projects\My-Todoist\MyTodoist\Pages\UserRegistration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3dfe73626633120e627d9ffb8d137d6c1bdff8"
// <auto-generated/>
#pragma warning disable 1591
namespace MyTodoist.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\My-Todoist\MyTodoist\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\My-Todoist\MyTodoist\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\My-Todoist\MyTodoist\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\My-Todoist\MyTodoist\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\My-Todoist\MyTodoist\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\My-Todoist\MyTodoist\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\My-Todoist\MyTodoist\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\My-Todoist\MyTodoist\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\My-Todoist\MyTodoist\_Imports.razor"
using MyTodoist;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\My-Todoist\MyTodoist\_Imports.razor"
using MyTodoist.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/usergistration")]
    public partial class UserRegistration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-6");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group");
            __builder.AddMarkupContent(6, "<label for=\"FirstName\" class=\"control-label\">First Name</label>\r\n            ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "for", "FirstName");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "D:\Projects\My-Todoist\MyTodoist\Pages\UserRegistration.razor"
                                                                userRegistration.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userRegistration.FirstName = __value, userRegistration.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "<label for=\"LastName\" class=\"control-label\">Last Name</label>\r\n            ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "for", "LastName");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\Projects\My-Todoist\MyTodoist\Pages\UserRegistration.razor"
                                                               userRegistration.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userRegistration.LastName = __value, userRegistration.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group");
            __builder.AddMarkupContent(24, "<label for=\"EmailId\" class=\"control-label\">Email Address</label>\r\n            ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "for", "EmailId");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\Projects\My-Todoist\MyTodoist\Pages\UserRegistration.razor"
                                                              userRegistration.EmailId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userRegistration.EmailId = __value, userRegistration.EmailId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-md-4");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-group");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "class", "btn btn-primary");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\Projects\My-Todoist\MyTodoist\Pages\UserRegistration.razor"
                                                                        SaveUserRegistration

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "button");
            __builder.AddAttribute(45, "class", "btn");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\Projects\My-Todoist\MyTodoist\Pages\UserRegistration.razor"
                                                            Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\Projects\My-Todoist\MyTodoist\Pages\UserRegistration.razor"
       

    MyTodoist.Data.UserRegistration userRegistration = new MyTodoist.Data.UserRegistration();
    MyTodoist.IService.IUserRegistrationService userRegistrationService;

    protected async Task SaveUserRegistration()
    {
        await userRegistrationService.SaveUserRegistration(userRegistration);
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("index");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
