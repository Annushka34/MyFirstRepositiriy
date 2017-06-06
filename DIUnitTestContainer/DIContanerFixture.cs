using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DIContainerDLL;

namespace DIUnitTestContainer
{
    [TestClass]
    public class DIContanerFixture
    {
        [TestMethod]
        public void RegisterType()
        {
            DIContainer container = new DIContainer();
            container.Register<IRegisterType, ResolverType>();
            Assert.IsTrue(container.RegisterTypes.Count == 1);
        }
    }
}
