using Microsoft.AspNetCore.Mvc;

namespace AliceHook.Controllers
{
    [ApiController]
    [Route(template:"/")]
    public class MyControler:ControllerBase
    {
        [HttpGet]
        public string GetFunc()
        {
            return "Rabotaet epta!";
        }
    }
}
