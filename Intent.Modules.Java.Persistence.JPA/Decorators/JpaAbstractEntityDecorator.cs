using System.Collections.Generic;
using Intent.Modules.Common.Java.Templates;
using Intent.Modules.Java.Domain.Templates.AbstractEntity;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.TemplateDecorator", Version = "1.0")]

namespace Intent.Modules.Java.Persistence.JPA.Decorators
{
    [IntentManaged(Mode.Merge)]
    public class JpaAbstractEntityDecorator : AbstractEntityDecorator, IDeclareImports
    {
        [IntentManaged(Mode.Fully)]
        public const string DecoratorId = "Intent.Java.Persistence.JPA.JpaAbstractEntityDecorator";

        private readonly AbstractEntityTemplate _template;

        public JpaAbstractEntityDecorator(AbstractEntityTemplate template)
        {
            _template = template;
        }

        public override IEnumerable<string> ClassAnnotations()
        {
            yield return "@MappedSuperclass";
        }

        public override string Fields()
        {
            return @"
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Integer id;

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public boolean isNew() {
		return this.id == null;
	}
";
        }

        public IEnumerable<string> DeclareImports()
        {
            yield return "javax.persistence.GeneratedValue";
            yield return "javax.persistence.GenerationType";
            yield return "javax.persistence.Id";
            yield return "javax.persistence.MappedSuperclass";

        }
    }
}