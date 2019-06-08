using IdentityServer4.Models;
using System.Collections.Generic;

namespace Dexterity.Login.BuiltInClients
{
    public static class DummyClientFactory
    {
        /// <summary>
        /// Dummy client to keep IdentityServer happy until we define some real ones
        /// </summary>
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "initialclient",
                    ClientSecrets = { new Secret("initialclientsecret".Sha256())}
                }
            };
        }
    }
}
