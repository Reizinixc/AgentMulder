﻿using System.Collections.Generic;
using System.Linq;
using AgentMulder.Containers.CastleWindsor.Patterns.FromTypes.WithService;
using AgentMulder.ReSharper.Domain.Registrations;
using AgentMulder.ReSharper.Domain.Search;
using JetBrains.ReSharper.Psi.Services.StructuralSearch;
using JetBrains.ReSharper.Psi.Tree;

namespace AgentMulder.Containers.CastleWindsor.Patterns.FromTypes.BasedOn
{
    public abstract class BasedOnRegistrationBase : RegistrationBase
    {
        private readonly WithServiceRegistrationBase[] withServicePatterns;

        protected BasedOnRegistrationBase(IStructuralSearchPattern pattern,
                                          params WithServiceRegistrationBase[] withServicePatterns)
            : base(pattern)
        {
            this.withServicePatterns = withServicePatterns;
        }

        public override IEnumerable<IComponentRegistration> GetComponentRegistrations(ITreeNode parentElement)
        {
            return withServicePatterns.SelectMany(withServicePattern => withServicePattern.GetComponentRegistrations(parentElement));
        }
    }
}