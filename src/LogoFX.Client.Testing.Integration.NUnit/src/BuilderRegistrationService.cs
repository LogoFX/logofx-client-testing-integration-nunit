using Attest.Testing.NUnit;
using LogoFX.Client.Testing.Contracts;
using Solid.Patterns.Builder;

namespace LogoFX.Client.Testing.Integration.NUnit
{
    /// <summary>
    /// Represents builder registration service for NUnit-based integration tests.
    /// </summary>
    /// <seealso cref="StepsBase" />
    /// <seealso cref="IBuilderRegistrationService" />
    public class BuilderRegistrationService : StepsBase, IBuilderRegistrationService
    {
        void IBuilderRegistrationService.RegisterBuilder<TService>(IBuilder<TService> builder)
        {
            RegisterBuilder(builder);
        }
    }
}
