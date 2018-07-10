using FrontEndWithTest;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace FrontEndTestPart
{
    public class UnitTest1
    {
        public HttpClient Client { get; set; }
        public TestServer Server { get; set; }

        public UnitTest1()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ShouldGetOKResponse()
        {
            var response = await Client.GetAsync("/Doubling");
            var statusCode = response.StatusCode;
            Assert.Equal(HttpStatusCode.OK, statusCode);
        }

        [Fact]
        public async Task ShouldGetBadReq()
        {
            var response = await Client.GetAsync("/Doublingo");
            var statusCode = response.StatusCode;
            Assert.Equal(HttpStatusCode.NotFound, statusCode);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(40)]
        public async Task ShouldGetDoubledAmount(int? input)
        {
            var response = await Client.GetAsync("/Doubling?input=" + input);
            Assert.Equal(JsonConvert.SerializeObject(new { received = input, result = input * 2 }),
                response.Content.ReadAsStringAsync().Result);
        }

        [Theory]
        [InlineData("Kinga", "student")]
        [InlineData("Nori", "teacher")]
        public async Task ShouldGetSameText(string name, string title)
        {
            var response = await Client.GetAsync($"/Greeter?name={name}&title={title}");
            Assert.Equal(JsonConvert.SerializeObject(new { welcome_message = "Oh, hi there " + name + ", my dear " + title + "!" }),
                response.Content.ReadAsStringAsync().Result);
        }
    }
}
