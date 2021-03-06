using System.Collections.Generic;
using Intent.Engine;
using Intent.Modelers.Services.Api;
using Intent.Modules.Common.Java;
using Intent.Modules.Common.Java.Templates;
using Intent.Modules.Common.Templates;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Java.Templates.JavaFileTemplatePartial", Version = "1.0")]

namespace Intent.Modules.Java.Services.Templates.DataTransferModel
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class DataTransferModelTemplate : JavaTemplateBase<Intent.Modelers.Services.Api.DTOModel, DataTransferModelDecorator>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Intent.Java.Services.DataTransferModel";

        [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
        public DataTransferModelTemplate(IOutputTarget outputTarget, Intent.Modelers.Services.Api.DTOModel model) : base(TemplateId, outputTarget, model)
        {
            AddDependency(new JavaDependency("org.projectlombok", "lombok", "1.18.12"));
            AddTypeSource(TemplateId, type => $"{ImportType("java.util.List")}<{type}>");
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public override ITemplateFileConfig GetTemplateFileConfig()
        {
            return new JavaFileConfig(
                className: $"{Model.Name}",
                package: $"{OutputTarget.GetPackage()}"
            );
        }

    }
}