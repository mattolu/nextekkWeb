#pragma checksum "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aa768cfcfc53345d9f28db7a48c26e1ee77b984"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Create), @"mvc.1.0.view", @"/Views/Employee/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Create.cshtml", typeof(AspNetCore.Views_Employee_Create))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\_ViewImports.cshtml"
using EmployeeWeb;

#line default
#line hidden
#line 2 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\_ViewImports.cshtml"
using EmployeeWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aa768cfcfc53345d9f28db7a48c26e1ee77b984", @"/Views/Employee/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0489c4b5b56ff6ba086d32adcde725547d430e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
  
    ViewBag.Title = "New Employee";

#line default
#line hidden
            BeginContext(61, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(68, 13, false);
#line 6 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(81, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
 using(Html.BeginForm()){

#line default
#line hidden
            BeginContext(117, 32, true);
            WriteLiteral("  <div class=\"form-group\">\r\n    ");
            EndContext();
            BeginContext(150, 39, false);
#line 10 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(189, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(196, 71, false);
#line 11 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.TextBoxFor(model => model.FirstName, new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(267, 45, true);
            WriteLiteral(" \r\n  </div>\r\n  <div class=\"form-group\">\r\n    ");
            EndContext();
            BeginContext(313, 38, false);
#line 14 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(351, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(358, 70, false);
#line 15 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.TextBoxFor(model => model.LastName, new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(428, 45, true);
            WriteLiteral(" \r\n  </div>\r\n  <div class=\"form-group\">\r\n    ");
            EndContext();
            BeginContext(474, 41, false);
#line 18 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.LabelFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(515, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(522, 73, false);
#line 19 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.TextBoxFor(model => model.DateOfBirth, new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(595, 46, true);
            WriteLiteral(" \r\n  </div>\r\n   <div class=\"form-group\">\r\n    ");
            EndContext();
            BeginContext(642, 33, false);
#line 22 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.LabelFor(model => model.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(675, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(682, 65, false);
#line 23 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.TextBoxFor(model => model.Sex, new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(747, 46, true);
            WriteLiteral(" \r\n  </div>\r\n   <div class=\"form-group\">\r\n    ");
            EndContext();
            BeginContext(794, 43, false);
#line 26 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.LabelFor(model => model.MaritalStatus));

#line default
#line hidden
            EndContext();
            BeginContext(837, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(844, 75, false);
#line 27 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.TextBoxFor(model => model.MaritalStatus, new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(919, 47, true);
            WriteLiteral(" \r\n  </div>\r\n    <div class=\"form-group\">\r\n    ");
            EndContext();
            BeginContext(967, 38, false);
#line 30 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1012, 70, false);
#line 31 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.TextBoxFor(model => model.Password, new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(1082, 45, true);
            WriteLiteral(" \r\n  </div>\r\n  <div class=\"form-group\">\r\n    ");
            EndContext();
            BeginContext(1128, 45, false);
#line 34 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.LabelFor(model => model.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1180, 77, false);
#line 35 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.TextBoxFor(model => model.ConfirmPassword, new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 46, true);
            WriteLiteral(" \r\n  </div>\r\n   <div class=\"form-group\">\r\n    ");
            EndContext();
            BeginContext(1304, 46, false);
#line 38 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.LabelFor(model => model.NumberOfChildren));

#line default
#line hidden
            EndContext();
            BeginContext(1350, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1357, 78, false);
#line 39 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
Write(Html.TextBoxFor(model => model.NumberOfChildren, new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 78, true);
            WriteLiteral(" \r\n  </div>\r\n  <button type=\"submit\" class=\"btn btn-default\">Submit</button>\r\n");
            EndContext();
#line 42 "C:\Users\OLUSAYO\Desktop\EmployeeWeb\Views\Employee\Create.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
