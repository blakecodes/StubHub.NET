using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stubhub.ClientLibrary;
using Stubhub.ClientLibrary.Transfer.Events;
using System.Threading.Tasks;

namespace Stubhub.ClientLibrary
{
    [TestClass]
    public class GeneralServiceTests
    {
        private StubhubService _stubhubService;
        public GeneralServiceTests()
        {
            this._stubhubService = new StubhubService();
        }

        [TestMethod]
        public async Task GetInventory_FromStubHub_ReturnsArray()
        {
            var res = await this._stubhubService.GetInventory(103771750);
            Assert.IsNotNull(res);
        }


        [TestMethod]
        public async Task SearchEvents_FromStubHub_ReturnsArray()
        {
            EventSearchRequest req = new EventSearchRequest();
            req.Q = "Tulsa";
            var res = await this._stubhubService.SearchEvents(req);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public async Task GetPerfromers_FromStubhub_ReturnsArray()
        {
            await this._stubhubService.GetPerformers();
        }

        [TestMethod]
        public async Task GetVenues_FromStubhub_ReturnsArray()
        {
            var res = await this._stubhubService.GetVenues();
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public async Task GetCategories_FromStubhub_ReturnsArray()
        {
            var res = await this._stubhubService.GetCategories();
            Assert.IsNotNull(res);
        }
    }
}
