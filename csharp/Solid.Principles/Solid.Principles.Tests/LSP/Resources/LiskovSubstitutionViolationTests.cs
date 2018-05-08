using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Solid.Principles.LSPViolation.Resources;

namespace Solid.Principles.Tests.LSP.Resources
{
    [TestClass]
    public class LiskovSubstitutionViolationTests
    {
        [TestMethod]
        public void TestProgramForLSPViolation()
        {
            var resources = LoadAll();
            SaveAll(resources);
        }

        public List<IPersistedResource> LoadAll()
        {
            var resources = new List<IPersistedResource>()
            {
                new ApplicationSettings(),
                new UserSettings(),
                new SpecialSettings(),
            };

            resources.ForEach(r => r.Load());
            return resources;
        }

        public void SaveAll(List<IPersistedResource> resources)
        {
            resources.ForEach(r => r.Persist());
        }
    }
}
