using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionSeguridad.Controllers
{
    public class TestController : Controller
    {
        [Authorize(Roles ="Administrador,Finanzas")]
        public IActionResult Identity()
        {
            return Content("Bievenido Administrador");
        }
        [Authorize(Roles = "Finanzas,Contabilidad")]
        public IActionResult NoIdentity()
        {
            return Content("Bievenido Finanzas");
        }
        [Authorize(Roles ="Contabilidad")]
        public IActionResult NoIdentity2()
        {
            return Content("Bievenido Contabilidad");
        }
    }
}
