using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicos
{
    //[Route("api/[controller]")] (*apago essa routa)


    [ApiController]
    public class AlunoController : ControllerBase
    {
        List<nomealuno> alunos = new List<nomealuno>();



        public AlunoController()
        {

           alunos.Add(new nomealuno { nome = "João", idade = "80", Id = 1 });
           alunos.Add(new nomealuno { nome = "Maria", idade = "84", Id = 2 });
           alunos.Add(new nomealuno { nome = "José", idade = "88", Id = 3 });
           alunos.Add(new nomealuno { nome = "Raimundo", idade = "92", Id = 4 });
           alunos.Add(new nomealuno { nome = "Manoel", idade = "96", Id = 5 });
           alunos.Add(new nomealuno { nome = "Francisco", idade = "100", Id = 6 });
           alunos.Add(new nomealuno { nome = "Joaquim", idade = "104", Id = 7 });
           alunos.Add(new nomealuno { nome = "Enzo", idade = "108", Id = 8 });
       

        }

        [Route("todosnomes")]
        [HttpGet]

        public List<nomealuno> GetALLnomes()
        {
            return alunos;
        }

        [Route("nomeporid")]
        [HttpGet]

        public nomealuno GetnomealunoPorId(int id)
        {

            return alunos.Where(x => x.Id == id).FirstOrDefault();

        }

    }



    public class nomealuno
    {
        public int Id { get; set; }

        public string idade { get; set; }

        public string nome { get; set; }
    }


}

    
    


