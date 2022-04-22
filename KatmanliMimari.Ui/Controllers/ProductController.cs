using KatmanliMimari.Ui.Models;
using KatmanliMimari.Uow;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliMimari.Ui.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitofWork _unitofWork;
        private readonly ProductModel _model;

        public ProductController(IUnitofWork unitofWork,ProductModel model)
        {
            _unitofWork = unitofWork;
            _model = model;
        }
        public IActionResult List()
        {
            var x=_unitofWork._proRepos.GetProductsSelects();
            return View(x);
        }
        public IActionResult Create()
        {
            _model.CategoriesSelects = _unitofWork._catRepos.GetCategoriesSelects();
            _model.BtnClass = "btn btn-primary";
            _model.BtnVal = "Create";
            _model.BtnHead = "Create";
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(ProductModel model)
        {
            _unitofWork._proRepos.Create(model.Products);
            _unitofWork.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)
        {
            _model.CategoriesSelects = _unitofWork._catRepos.GetCategoriesSelects();
            _model.Products = _unitofWork._proRepos.Find(id);
            _model.BtnClass = "btn btn-success";
            _model.BtnVal = "Edit";
            _model.BtnHead = "Edit";
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(ProductModel model)
        {
            _unitofWork._proRepos.Update(model.Products);
            _unitofWork.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            _model.CategoriesSelects = _unitofWork._catRepos.GetCategoriesSelects();
            _model.Products = _unitofWork._proRepos.Find(id);
            _model.BtnClass = "btn btn-danger";
            _model.BtnVal = "Delete";
            _model.BtnHead = "Delete";
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(ProductModel model)
        {
            _unitofWork._proRepos.Delete(model.Products);
            _unitofWork.Commit();
            return RedirectToAction("List");
        }
    }
}
