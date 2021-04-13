using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DTOS.Dto;

namespace Service.CategoryServices
{
    public interface ICategoryService
    {
        Task<IEnumerable<OutputCategoryDto>> Get();
    }
}
