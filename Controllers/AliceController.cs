using System;
using System.IO;
using System.Threading.Tasks;
using AliceHook.Engine;
using AliceHook.Models;
using AliceHook.Models.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;



namespace AliceHook.Controllers
{
    [ApiController]
    [Route("/")]
    public class AliceController : ControllerBase
    {
        private readonly AliceService _aliceService;

        private static readonly JsonSerializerSettings ConvertSettings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy() // настройки NamingStrategy, для входящего запроса. 
            }
        };
        public AliceController(AliceService aliceService)
        {
            _aliceService = aliceService;
        }

        [HttpGet]
        public string Get()
        {
            return "Rabotaet epta!";
        }

        [HttpPost]
        public Task Post()
        {
            using var reader = new StreamReader(Request.Body); //using освободит память после конца функции
            var body = reader.ReadToEnd();  // читаем, то что пришло в запросе.

            var aliceRequest = JsonConvert.DeserializeObject<AliceRequest>(body, ConvertSettings); // Превращаем в класс
            if (aliceRequest?.IsPing() == true)
            {
                AliceResponseBase<UserState, SessionState> pongResponse = new AliceResponse(aliceRequest).ToPong();
                string stringPong = JsonConvert.SerializeObject(pongResponse, ConvertSettings);
                return Response.WriteAsync(stringPong);
            }

            string userId = aliceRequest.Session.UserId;
            Console.WriteLine($"REQUEST FROM {userId}:\n{body}\n");

            AliceResponse aliceResponse = _aliceService.HandleRequest(aliceRequest);
            string stringResponse = JsonConvert.SerializeObject(aliceResponse, ConvertSettings);

            Console.WriteLine($"RESPONSE:\n{stringResponse}\n");

            return Response.WriteAsync(stringResponse);
        }


    }
}
