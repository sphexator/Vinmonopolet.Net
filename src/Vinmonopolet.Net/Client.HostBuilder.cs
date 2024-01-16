using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Vinmonopolet.Entities;
using Vinmonopolet.Entities.Clients;
using Vinmonopolet.Entities.Constants;
using Vinmonopolet.Entities.Interfaces;

namespace Vinmonopolet;

public static class ClientHostBuilder
{
	public static IHostApplicationBuilder AddVinmonopolet(this IHostApplicationBuilder builder, Action<VinmonopoletOptions> options)
	{
		var option = new VinmonopoletOptions();
		options.Invoke(option);
		builder.Services.Configure(options);
		builder.Services.AddScoped<VinmonopoletClient>();
		builder.Services.AddHttpClient<IClient, VinmonopoletClient>(client =>
		{
			client.BaseAddress = new(Constant.BaseUri);
			client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", option.ApiKey.TrimEnd(' ').TrimStart(' '));
		});
		return builder;
	}
}