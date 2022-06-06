using crud_biblioteca.Models;
using crud_biblioteca.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace crud_biblioteca.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (loginModel.Login == "adm" && loginModel.Senha == "123")
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }

                TempData["Message"] = "Usuário ou senha inválidos";
            }
            catch (Exception error)
            {
                TempData["Message"] = $"Não foi possível realizar seu login, tente novamente: {error.Message}";
                return RedirectToAction("Index");
            }

            return View("Index");
        }

    }
}
