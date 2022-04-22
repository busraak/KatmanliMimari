using KatmanliMimari.Entity.Users;
using KatmanliMimari.Ui.Models;
using KatmanliMimari.Uow;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliMimari.Ui.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitofWork _unitofWork;
        private readonly UserModel _model;

        public UserController(IUnitofWork unitofWork,UserModel model)
        {
            _unitofWork = unitofWork;
            _model = model;
        }
        public IActionResult List()
        {
          List<AspNetUser> x = _unitofWork._userRepos.GetUsers();
                
            return View(x);
        }
        public IActionResult Create()
        {
            _model.RoleSelect=_unitofWork._roleRepos.GetRoles();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(UserModel model,string id)
        {
            //model.AspNetUsers = _unitofWork._userRepos.Find(id);

            _unitofWork._userRepos.Create(model.AspNetUsers);
            _unitofWork.Commit();
            return RedirectToAction();
        }
    }
}
