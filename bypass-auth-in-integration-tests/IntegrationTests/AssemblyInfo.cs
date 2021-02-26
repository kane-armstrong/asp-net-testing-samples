using IntegrationTests.Infrastructure;
using IntegrationTests.Infrastructure.XUnit;
using Xunit;

[assembly: TestFramework("IntegrationTests.Infrastructure.XUnit.XunitTestFrameworkWithAssemblyFixture", "IntegrationTests")]
[assembly: AssemblyFixture(typeof(TestFixture))]