using BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents._BlogReadAllPartialComponents
{
    public class _BlogReadAllCategoryComponents:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _BlogReadAllCategoryComponents(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TGetListAll();
            return View(values);
        }
    }
}
