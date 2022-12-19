using F1Emu.Api.Domain.Laps;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Testing;

namespace F1Emu.Api.Tests
{
    public class F1EmuApiWebApplicationFactory : WebApplicationFactory<Program>
    {

        protected override IHost CreateHost(IHostBuilder builder)
        {
            builder.ConfigureServices(s => {
                s.AddSingleton<ILapRepository>(new TestLapRespository());
            });

            return base.CreateHost(builder);
        }
    }
}