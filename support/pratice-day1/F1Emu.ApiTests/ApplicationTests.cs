using Xunit;
using F1Emu.Api.Infrastructure.SqlLap;
using Microsoft.AspNetCore.Mvc.Testing;
using F1Emu.Api.Domain.Laps;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Json;
using System.Net;

namespace F1Emu.Api.Tests
{
    public partial class ApplicationTests
    {
        private F1EmuApiWebApplicationFactory webApplicationFactory;

        public ApplicationTests()
        {
            webApplicationFactory = new F1EmuApiWebApplicationFactory();
        }
        [Fact()]
        public async Task PostTest()
        {
            var client = webApplicationFactory.CreateDefaultClient();
            var result = await client.PostAsJsonAsync<AddLapRequest>("/laps", new() { DriverName = "Lauda", ElapsedTime = "01:26.001", SectorTime = "00:18.020", Sector = 3, LapIndex = 3 });
            result.EnsureSuccessStatusCode();
            var lap = await result.Content.ReadFromJsonAsync<Lap>();
            Assert.NotNull(lap);
            Assert.NotEqual(Guid.Empty, lap.Id);
        }
        [Fact()]
        public async Task GetTest()
        {
            var client = webApplicationFactory.CreateDefaultClient();
            var result = await client.GetAsync("/laps");
            result.EnsureSuccessStatusCode();
        }
    }
}