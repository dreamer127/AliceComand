using Microsoft.AspNetCore.Mvc;

namespace AliceHook.Controllers
{
    [ApiController]
    [Route(template:"/")]
    public class AliceController:ControllerBase
    {
        [HttpGet]
        public string GetFunc()
        {
            return "Rabotaet epta!";
        }
    }
}
