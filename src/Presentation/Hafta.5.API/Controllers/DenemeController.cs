using Hafta._5.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hafta._5.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DenemeController : ControllerBase
    {
        private IUserExportExcel _userExportExcel;
        public DenemeController(IUserExportExcel userExportExcel)
        {
            _userExportExcel = userExportExcel;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _userExportExcel.Export();
            return Ok();
        }
    }
}
