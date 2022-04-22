using KatmanliMimari.Ui.Models;
using KatmanliMimari.Uow;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliMimari.Ui.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitofWork _unitofWork;
        private readonly CategoryModel _model;

        public CategoryController(IUnitofWork unitofWork,CategoryModel model)
        {
            _unitofWork = unitofWork;
            _model = model;
        }
        public IActionResult List()
        {
            var x=_unitofWork._catRepos.GetCategoriesSelects();
            return View(x);
        }
        public IActionResult Create()
        {

            _model.BtnClass = "btn btn-primary";
            _model.BtnVal = "Create";
            _model.BtnHead = "Create";
            return View("Crud",_model);
        }
        [HttpPost]
        public IActionResult Create(CategoryModel model)
        {
            _unitofWork._catRepos.Create(model.Categories);
            _unitofWork.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)
        {

            _model.BtnClass = "btn btn-success";
            _model.BtnVal = "Edit";
            _model.BtnHead = "Edit";
            _model.Categories = _unitofWork._catRepos.Find(id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(CategoryModel model)
        {
            _unitofWork._catRepos.Update(model.Categories);
            _unitofWork.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {

            _model.BtnClass = "btn btn-danger";
            _model.BtnVal = "Delete";
            _model.BtnHead = "Delete";
            _model.Categories = _unitofWork._catRepos.Find(id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(CategoryModel model)
        {
            _unitofWork._catRepos.Delete(model.Categories);
            _unitofWork.Commit();
            return RedirectToAction("List");
        }
    }
}
