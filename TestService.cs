namespace Reqnroll.PluginTester
{
    public interface ITestService
    {
        bool Verify();
    }

    public class TestService : ITestService
    {
        public bool Verify()
        {
            return true;
        }
    }
}
