using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DTOS.Dto;
using Repo.Repository.CategoryRepository;


namespace Service.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<OutputCategoryDto>> Get()
        {
            var res = await _categoryRepository.GetAllAsync(expression: null, include: null);
            return _mapper.Map<IEnumerable<OutputCategoryDto>>(res);
        }
    }
}
