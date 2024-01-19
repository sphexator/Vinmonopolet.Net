using Vinmonopolet.Entities.Interfaces;

namespace Vinmonopolet.Entities.Clients;

public sealed class VinmonopoletClient : IClient
{
	public VinmonopoletClient(IAuthClient auth, IMyProductsClient myProducts, 
			IProductsClient products, IStoreClient stores)
	{
		Auth = auth;
		MyProducts = myProducts;
		Products = products;
		Stores = stores;
	}

	public IAuthClient Auth { get; }
	public IMyProductsClient MyProducts { get; }
	public IProductsClient Products { get; }
	public IStoreClient Stores { get; }
}