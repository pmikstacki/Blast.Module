using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Blast.Module;

public interface IBlastModule
{
    IServiceCollection ConfigureModule(IServiceCollection services, IConfiguration configuration);

    void ConfigureApplication(IApplicationBuilder app);
}