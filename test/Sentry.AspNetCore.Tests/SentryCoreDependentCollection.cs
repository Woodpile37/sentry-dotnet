using Xunit;

namespace Sentry.AspNetCore.Tests
{
    [CollectionDefinition(nameof(AspNetSentrySdkTestBase))]
    public sealed class TestServerCollection : ICollectionFixture<AspNetSentrySdkTestBase>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
        // See: http://xunit.github.io/docs/shared-context.html#collection-fixture
    }
}
