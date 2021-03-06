using System.Collections.Generic;
using Intent.Modelers.Domain.Api;
using Intent.Modules.Common.Java.Templates;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Ignore)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.TemplateDecoratorContract", Version = "1.0")]

namespace Intent.Modules.Java.Domain.Templates.DomainModel
{
    [IntentManaged(Mode.Merge)]
    public abstract class DomainModelDecorator : ITemplateDecorator
    {
        public int Priority { get; protected set; } = 0;

        public virtual string ClassAnnotations() => null;

        public virtual string BeforeField(AttributeModel model) => null;

        public virtual string BeforeField(AssociationEndModel model) => null;
    }
}