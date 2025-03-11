using BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjeKampi.ViewComponents._WriterDashboardComponents
{
    public class _WriterDashboardCategoryListComponents:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _WriterDashboardCategoryListComponents(ICategoryService categoryService)
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
