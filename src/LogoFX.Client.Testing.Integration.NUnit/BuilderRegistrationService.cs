using Attest.Testing.Core.NUnit;
using Attest.Testing.FakeData;
using Solid.Patterns.Builder;
using Solid.Practices.IoC;

namespace LogoFX.Client.Testing.Integration.NUnit
{
    /// <summary>
    /// Represents builder registration service for NUnit-based integration tests.
    /// </summary>
    /// <seealso cref="StepsBase" />
    /// <seealso cref="IBuilderRegistrationService" />
    public class BuilderRegistrationService : StepsBase, IBuilderRegistrationService
    {
        /// <summary>
        /// Initializes a new instance of <see cref="BuilderRegistrationService"/>
        /// </summary>
        /// <param name="dependencyRegistrator"></param>
        /// <param name="dependencyResolver"></param>
        public BuilderRegistrationService(
            IDependencyRegistrator dependencyRegistrator, 
            IDependencyResolver dependencyResolver)
        :base(dependencyRegistrator, dependencyResolver) {}

        void IBuilderRegistrationService.RegisterBuilder<TService>(IBuilder<TService> builder)
        {
            RegisterBuilderProduct(builder);
        }
    }
}
