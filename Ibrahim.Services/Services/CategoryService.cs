using Ibrahim.Core;
using Ibrahim.Core.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ibrahim.Core.Domain.Entities;
using System.Linq;
using Ibrahim.Core.Services;
using AutoMapper;
using Ibrahim.Core.Mappers;
using Ibrahim.Core.Domain.Common;

namespace Ibrahim.Services.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitWork Database;
        private readonly IMapper Mapper;
        
        public CategoryService(IUnitWork uWork, IMapper mapper)
        {
            Database = uWork;
            Mapper = mapper;
        }

        public void AddCategory(CategoryDto categoryDto)
        {
            var category = Mapper.Map<CategoryDto, Category>(categoryDto);
            Database.CategoryRepo.Insert(category);
            Database.Commit();
        }

        public void DeleteCategory(int? categoryId)
        {
            if (!categoryId.HasValue)
                throw new ParameterException("Id", "Category", "Kategori numarası gönderilmedi.");
            var category = Database.CategoryRepo.GetById(categoryId.Value);
            if (category == null)
                throw new ParameterException("Id", "Category", "Gönderilen kategori numarası geçerli değil.");

            Database.CategoryRepo.Delete(category);
            Database.Commit();
        }

        public async Task<IEnumerable<CategoryDto>> GetAllCategories()
        {
            var categories = await Database.CategoryRepo.GetAllAsync(false);
            var categoryDtos=Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDto>>(categories);
            return categoryDtos;
        }

        public CategoryDto GetCategoryById(int? categoryId,bool isTracking=true)
        {
            if (!categoryId.HasValue)
                throw new ParameterException("Id", "Category", "Kategori numarası gönderilmedi.");
            var category=Database.CategoryRepo.GetById(categoryId.Value,isTracking);
            if(category==null)
                throw new ParameterException("Id", "Category", "Gönderilen kategori numarası geçerli değil.");
            var categoryDto = Mapper.Map<Category, CategoryDto>(category);
            return categoryDto;
        }

        public void UpdateCategory(CategoryDto categoryDto)
        {
            if (categoryDto.Id == 0)
                throw new ParameterException("Id", "Category", "Güncellenecek kategori numarası gönderilmedi.");
            var category = Mapper.Map<CategoryDto, Category>(categoryDto);
            Database.CategoryRepo.Update(category);
            Database.Commit();
        }
    }
}
