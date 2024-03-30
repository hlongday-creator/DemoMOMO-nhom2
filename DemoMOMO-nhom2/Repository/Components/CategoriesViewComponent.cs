using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoMOMO_nhom2.Repository.Components
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly DataContext _dataContext;
        public CategoriesViewComponent(DataContext context)
        {
            _dataContext = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            try
            {
				var result = await _dataContext.Categories.ToListAsync();
				return View(result);
			}
            catch (Exception ex)
            {
                View(ex); return View();
            }
            
            //return View();
        }

    }
}
