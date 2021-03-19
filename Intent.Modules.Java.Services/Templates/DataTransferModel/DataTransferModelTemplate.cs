// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Intent.Modules.Java.Services.Templates.DataTransferModel
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
    
    #line 1 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\DataTransferModel\DataTransferModelTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class DataTransferModelTemplate : JavaTemplateBase<Intent.Modelers.Services.Api.DTOModel, Intent.Modules.Java.Services.Templates.DataTransferModel.DataTransferModelDecorator>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("package ");
            
            #line 11 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\DataTransferModel\DataTransferModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Package));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\nimport lombok.AllArgsConstructor;\r\nimport lombok.Data;\r\nimport lombok.NoArgs" +
                    "Constructor;\r\n\r\n@AllArgsConstructor\r\n@NoArgsConstructor\r\n@Data\r\npublic class ");
            
            #line 20 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\DataTransferModel\DataTransferModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 21 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\DataTransferModel\DataTransferModelTemplate.tt"
  foreach(var field in Model.Fields) { 
            
            #line default
            #line hidden
            this.Write("    private ");
            
            #line 22 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\DataTransferModel\DataTransferModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(field)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 22 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\DataTransferModel\DataTransferModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 23 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\DataTransferModel\DataTransferModelTemplate.tt"
  } 
            
            #line default
            #line hidden
            
            #line 23 "C:\Dev\Intent.Modules.Java\Intent.Modules.Java.Services\Templates\DataTransferModel\DataTransferModelTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDecoratorsOutput(x => x.Methods())));
            
            #line default
            #line hidden
            this.Write("\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
