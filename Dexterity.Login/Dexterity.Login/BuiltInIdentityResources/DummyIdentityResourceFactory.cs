using IdentityServer4.Models;
using System.Collections.Generic;

namespace Dexterity.Login.BuiltInIdentityResources
{
    public static class DummyIdentityResourceFactory
    {
        /// <summary>
        /// Dummy identity resource to keep IdentityServer happy until we define some real ones
        /// </summary>
        public static IEnumerable<IdentityResource> Get()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Phone()
            };
        }
    }
}
