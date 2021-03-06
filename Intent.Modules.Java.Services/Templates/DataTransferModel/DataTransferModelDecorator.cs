using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Ignore)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.TemplateDecoratorContract", Version = "1.0")]

namespace Intent.Modules.Java.Services.Templates.DataTransferModel
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public abstract class DataTransferModelDecorator : ITemplateDecorator
    {
        public int Priority { get; protected set; } = 0;

        public virtual string Methods()
        {
            return null;
        }
    }
}