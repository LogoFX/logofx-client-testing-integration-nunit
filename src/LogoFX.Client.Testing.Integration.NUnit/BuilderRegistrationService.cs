﻿using Attest.Fake.Builders;
using Attest.Testing.NUnit;
using LogoFX.Client.Testing.Contracts;

namespace LogoFX.Client.Testing.Integration.NUnit
{
    /// <summary>
    /// Represents builder registration service for NUnit-based integration tests.
    /// </summary>
    /// <seealso cref="StepsBase" />
    /// <seealso cref="IBuilderRegistrationService" />
    public class BuilderRegistrationService : StepsBase, IBuilderRegistrationService
    {
        void IBuilderRegistrationService.RegisterBuilder<TService>(FakeBuilderBase<TService> builder)
        {
            RegisterBuilder(builder);
        }
    }
}
