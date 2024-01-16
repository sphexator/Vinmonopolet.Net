using Vinmonopolet.Entities.Clients;

namespace Vinmonopolet.Entities.Interfaces;

public interface IClient
{
	IAuthClient Auth { get; }
	IMyProductsClient MyProducts { get; }
	IProductsClient Products { get; }
	IStoreClient Stores { get; }
}