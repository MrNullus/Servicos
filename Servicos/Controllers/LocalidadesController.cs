using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace Servicos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LocalidadesController : ControllerBase
    {
        [HttpGet]
        public List<string> GetEstados()
        {
            List<String> list = new List<String>();
            list.Add("SP");
            list.Add("BA");
            list.Add("MG");

            return list;
        }
    }
}
