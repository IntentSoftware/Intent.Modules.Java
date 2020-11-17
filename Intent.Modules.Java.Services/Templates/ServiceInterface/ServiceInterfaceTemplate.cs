// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Java.Services.Templates.ServiceInterface
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Modules.Common.Java.Templates;
    using Intent.Templates;
    using Intent.Metadata.Models;
    using Intent.Modelers.Services.Api;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\ServiceInterface\ServiceInterfaceTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ServiceInterfaceTemplate : JavaTemplateBase<ServiceModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("package ");
            
            #line 11 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\ServiceInterface\ServiceInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Package));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\npublic interface ");
            
            #line 13 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\ServiceInterface\ServiceInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 14 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\ServiceInterface\ServiceInterfaceTemplate.tt"
  foreach(var operation in Model.Operations) { 
            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 15 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\ServiceInterface\ServiceInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(operation)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 15 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\ServiceInterface\ServiceInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 15 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\ServiceInterface\ServiceInterfaceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.GetMethodParameters(operation.Parameters)));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n");
            
            #line 17 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\ServiceInterface\ServiceInterfaceTemplate.tt"
  } 
            
            #line default
            #line hidden
            this.Write("}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
