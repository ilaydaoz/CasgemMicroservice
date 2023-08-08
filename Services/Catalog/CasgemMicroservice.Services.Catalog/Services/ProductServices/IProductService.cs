using CasgemMicroservice.Services.Catalog.Dtos.ProductDtos;
using CasgemMicroservice.Shared.Dtos;

namespace CasgemMicroservice.Services.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<Response<List<ResultProductDto>>> GetAllProductListAsync();
        Task<Response<ResultProductDto>> GetByIdProductAsync(string id);
        Task<Response<NoContent>> CreateProductAsync(CreateProductDto createProduct);
        Task<Response<NoContent>> UpdateProductAsync(UpdateProductDto updateProduct);
        Task<Response<NoContent>> DeleteProductAsync(string id);
    }
}
