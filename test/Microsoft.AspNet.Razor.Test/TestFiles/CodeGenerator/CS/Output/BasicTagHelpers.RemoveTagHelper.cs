#pragma checksum "BasicTagHelpers.RemoveTagHelper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15609cf7c0bff12794453caa4d04e6f5a562e6ed"
namespace TestOutput
{
    using System;
    using System.Threading.Tasks;

    public class BasicTagHelpers.RemoveTagHelper
    {
        #line hidden
        public BasicTagHelpers.RemoveTagHelper()
        {
        }

        #pragma warning disable 1998
        public override async Task ExecuteAsync()
        {
            Instrumentation.BeginContext(72, 187, true);
            WriteLiteral("\r\n<div class=\"randomNonTagHelperAttribute\">\r\n    <p class=\"Hello World\">\r\n       " +
" <p></p>\r\n        <input type=\"text\" />\r\n        <input type=\"checkbox\" checked=" +
"\"true\"/>\r\n    </p>\r\n</div>");
            Instrumentation.EndContext();
        }
        #pragma warning restore 1998
    }
}
