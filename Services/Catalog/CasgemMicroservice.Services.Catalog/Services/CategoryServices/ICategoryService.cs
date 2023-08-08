﻿using CasgemMicroservice.Services.Catalog.Dtos.CategoryDtos;
using CasgemMicroservice.Shared.Dtos;

namespace CasgemMicroservice.Services.Catalog.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<Response<List<ResultCategoryDto>>> GetAllCategoryListAsync();
        Task<Response<ResultCategoryDto>> GetByIdCategoryAsync(string id);
        Task<Response<NoContent>> CreateCategoryAsync(CreateCategoryDto createCategory);
        Task<Response<NoContent>> UpdateCategoryAsync(UpdateCategoryDto updateCategory);
        Task<Response<NoContent>> DeleteCategoryAsync(string id);
    }
}
