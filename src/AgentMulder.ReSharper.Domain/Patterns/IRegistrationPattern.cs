using System.Collections.Generic;
using AgentMulder.ReSharper.Domain.Registrations;
using JetBrains.ReSharper.Psi.Services.StructuralSearch;
using JetBrains.ReSharper.Psi.Tree;

namespace AgentMulder.ReSharper.Domain.Patterns
{
    public interface IRegistrationPattern
    {
        IStructuralSearchPattern Pattern { get; }
        IStructuralMatcher Matcher { get; }
        IEnumerable<IComponentRegistration> GetComponentRegistrations(ITreeNode registrationRootElement);
    }
}