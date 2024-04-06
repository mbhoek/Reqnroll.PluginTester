using Xunit;

namespace Reqnroll.PluginTester.StepDefinitions
{
    [Binding]
    public class TestSteps
    {
        private readonly ITestService testService;

        public TestSteps(ITestService testService)
        {
            this.testService = testService;
        }

        [Then(@"my service has been injected")]
        public void ThenMyServiceHasBeenInjected()
        {
            Assert.True(testService.Verify());
        }
    }
}
