using KatmanliMimari.Ui.Models;
using KatmanliMimari.Uow;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliMimari.Ui.Controllers
{
    public class RoleController : Controller
    {
        private readonly IUnitofWork _unitofWork;
        private readonly RoleModel _model;

        public RoleController(IUnitofWork unitofWork,RoleModel model)
        {
            _unitofWork = unitofWork;
            _model = model;
        }
        public IActionResult List()
        {
            var x=_unitofWork._roleRepos.GetRoles();
            return View(x);
        }
        public IActionResult Create()
        {

            _model.BtnClass = "btn btn-primary";
            _model.BtnVal = "Create";
            _model.BtnHead = "Create";
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(RoleModel model)
        {
            _unitofWork._roleRepos.Create(model.AspNetRole);
            _unitofWork.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Edit(string id)
        {

            _model.BtnClass = "btn btn-success";
            _model.BtnVal = "Edit";
            _model.BtnHead = "Edit";
            _model.AspNetRole = _unitofWork._roleRepos.Find(id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(RoleModel model)
        {
            _unitofWork._roleRepos.Update(model.AspNetRole);
            _unitofWork.Commit();
            return RedirectToAction("List");
        }
        public IActionResult Delete(string id)
        {

            _model.BtnClass = "btn btn-danger";
            _model.BtnVal = "Delete";
            _model.BtnHead = "Delete";
            _model.AspNetRole = _unitofWork._roleRepos.Find(id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(RoleModel model)
        {
            _unitofWork._roleRepos.Delete(model.AspNetRole);
            _unitofWork.Commit();
            return RedirectToAction("List");
        }

    }
}
