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
            federacaos.Add(new EstadoFederacao { Estado = "Mato Grosso", Sigla = "MT", Id = 11 });
            federacaos.Add(new EstadoFederacao { Estado = "Mato Grosso do Sul", Sigla = "MS", Id = 12 });
            federacaos.Add(new EstadoFederacao { Estado = "Minas Gerais", Sigla = "MG", Id = 13 });
            federacaos.Add(new EstadoFederacao { Estado = "Pará", Sigla = "PA", Id = 14 });
            federacaos.Add(new EstadoFederacao { Estado = "Paraíba", Sigla = "PB", Id = 15 });
            federacaos.Add(new EstadoFederacao { Estado = "Paraná", Sigla = "PR", Id = 16 });
            federacaos.Add(new EstadoFederacao { Estado = "Pernambuco", Sigla = "PE", Id = 17 });
            federacaos.Add(new EstadoFederacao { Estado = "Piauí", Sigla = "PI", Id = 18 });
            federacaos.Add(new EstadoFederacao { Estado = "Rio de Janeiro", Sigla = "RJ", Id = 19 });
            federacaos.Add(new EstadoFederacao { Estado = "Rio Grande do Norte", Sigla = "RN", Id = 20 });
            federacaos.Add(new EstadoFederacao { Estado = "Rio Grande do Sul", Sigla = "RS", Id = 21 });
            federacaos.Add(new EstadoFederacao { Estado = "Rondônia", Sigla = "RO", Id = 22 });
            federacaos.Add(new EstadoFederacao { Estado = "Roraima", Sigla = "RR", Id = 23 });
            federacaos.Add(new EstadoFederacao { Estado = "Santa Catarina", Sigla = "SC", Id = 24 });
            federacaos.Add(new EstadoFederacao { Estado = "São Paulo", Sigla = "SP", Id = 25 });
            federacaos.Add(new EstadoFederacao { Estado = "Sergipe", Sigla = "SE", Id = 26 });
            federacaos.Add(new EstadoFederacao { Estado = "Tocantins", Sigla = "TO", Id = 27 });

        }

        [Route("todosestados")]
        [HttpGet]

        public List<EstadoFederacao> GetALLEstados()
        { 
            return federacaos;
        }

        [Route("estadoporid")]
        [HttpGet]

        public EstadoFederacao GetEstadoFederacaoPorId(int id)
        {
        
            return federacaos.Where(x => x.Id == id).FirstOrDefault();

        }

    }



    public class EstadoFederacao
    {
        public int Id { get; set; }

        public string Sigla { get; set; }

        public string Estado { get; set; }
    }


}
