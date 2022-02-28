using Mango.Web.Models;

namespace Mango.Web.Services.IServices;

public class ProductService : BaseService, IProductService
{
    public async Task<T> GetAllProductsAsync<T>()
    {
        return await SendAsync<T>(new ApiRequest
        {
            ApiType = SD.ApiType.GET,
            Url = SD.ProductAPIBase + "/api/products",
            AccessToken = ""
        });
    }

    public async Task<T> GetProductByIdAsync<T>(int id)
    {
        return await SendAsync<T>(new ApiRequest
        {
            ApiType = SD.ApiType.GET,
            Url = SD.ProductAPIBase + "/api/products/" + id,
            AccessToken = ""
        });
    }

    public async Task<T> CreateProductAsync<T>(ProductDto productDto)
    {
        return await SendAsync<T>(new ApiRequest
        {
            ApiType = SD.ApiType.POST,
            Data = productDto,
            Url = SD.ProductAPIBase + "/api/products",
            AccessToken = ""
        });
    }

    public async Task<T> UpdateProductAsync<T>(ProductDto productDto)
    {
        return await SendAsync<T>(new ApiRequest
        {
            ApiType = SD.ApiType.PUT,
            Url = SD.ProductAPIBase + "/api/products",
            Data = productDto,
            AccessToken = ""
        });
    }

    public async Task<T> DeleteProductAsync<T>(int id)
    {
        return await SendAsync<T>(new ApiRequest
        {
            ApiType = SD.ApiType.DELETE,
            Url = SD.ProductAPIBase + "/api/products/" + id,
            AccessToken = ""
        });
    }

    public ProductService(IHttpClientFactory httpClient) : base(httpClient)
    {
    }
}