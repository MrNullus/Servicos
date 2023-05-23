using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;


namespace Servicos.Controllers
{  
public class LocalidadesController : ControllerBase

{
    List<EstadoFederacao> federacaos= new List<EstadoFederacao>();



       public LocalidadesController()
        {

            federacaos.Add(new EstadoFederacao { Estado = "Acre", Sigla = "AC", Id = 1 });
            federacaos.Add(new EstadoFederacao { Estado = "Alagoas", Sigla = "AL", Id = 2 });
            federacaos.Add(new EstadoFederacao { Estado = "Amapá", Sigla = "AP", Id = 3 });
            federacaos.Add(new EstadoFederacao { Estado = "Amazonas", Sigla = "AM", Id = 4 });
            federacaos.Add(new EstadoFederacao { Estado = "Bahia", Sigla = "BA", Id = 5 });
            federacaos.Add(new EstadoFederacao { Estado = "Ceará", Sigla = "CE", Id = 6 });
            federacaos.Add(new EstadoFederacao { Estado = "Distrito Federal", Sigla = "DF", Id = 7 });
            federacaos.Add(new EstadoFederacao { Estado = "Espírito Santo", Sigla = "ES", Id = 8 });
            federacaos.Add(new EstadoFederacao { Estado = "Goiás", Sigla = "GO", Id = 9 });
            federacaos.Add(new EstadoFederacao { Estado = "Maranhão", Sigla = "MA", Id = 10 });

        }

        [Route("todosestados")]
        [HttpGet]

        public List<EstadoFederacao> GetAllEstados()
        { 
            return federacaos;
        }

        [Route("estadoporid")]
        [HttpGet]

        public EstadoFederacao GetEstadoFederacaoPorId(int id)
        {
            return federacaos.Where(x => x.Id == id).FirstOrDefault();
        }

        [HttpPost]
        [Route("inserirLocal")]
        public List<EstadoFederacao> InserirPorPost(EstadoFederacao estadoFederacao)
        {
            if (estadoFederacao != null)
            {
                federacaos.Add(estadoFederacao);
            }

            return federacaos;
        }

        [HttpPut]
        [Route("inserirPorPut")]
        public List<EstadoFederacao> InserirPorPut(EstadoFederacao estadoFederacao)
        {
            if (estadoFederacao != null)
            {
                federacaos.Add(estadoFederacao);
            }

            return GetAllEstados();
        }
    }



    public class EstadoFederacao
    {
        public int Id { get; set; }

        public string Sigla { get; set; }

        public string Estado { get; set; }
    }


}
