using System;
using System.Linq;
using Autofac;
using Reqnroll.Autofac;

namespace Reqnroll.PluginTester
{
    public static class TestDependencies
    {
        [ScenarioDependencies]
        public static ContainerBuilder CreateContainerBuilder()
        {
            // create container with the runtime dependencies
            var builder = new ContainerBuilder();
            builder.RegisterType<TestService>().As<ITestService>();

            //TODO: add customizations, stubs required for testing

            builder.RegisterTypes(typeof(TestDependencies).Assembly.GetTypes().Where(t => Attribute.IsDefined(t, typeof(BindingAttribute))).ToArray()).SingleInstance();

            return builder;
        }
    }
}
