using System.Web.Http;

using Galaxia.Negocio;
using Galaxia.Dominio;

namespace Galaxia.WebApi.Controllers
{
    [RoutePrefix("api/v1")]
    public class PlanetaController : ApiController
    {

        PlanetaNG _planetaNg;

        public PlanetaController()
        {
            _planetaNg = new PlanetaNG();
        }

        [HttpGet]
        [Route("Planeta")]
        public IHttpActionResult Selecionar()
        {
            var retorno = _planetaNg.Selecionar();
            return Ok(retorno);
        }

        [HttpGet]
        [Route("Planeta/{id}")]
        public IHttpActionResult SelecionarPorId(int id)
        {
            var retorno = _planetaNg.SelecionarPorId(id);
            return Ok(retorno);
        }
        [HttpPost]
        [Route("Planeta")]
        public IHttpActionResult Incluir(Planeta planeta)
        {
            _planetaNg.Incluir(planeta);
            return Created(Request.RequestUri +"/"+ planeta.Id, planeta);
        }

        [HttpPut]
        [Route("Planeta")]
        public IHttpActionResult Alterar(Planeta planeta)
        {
            _planetaNg.Alterar(planeta);
            return Ok();
        }

        [HttpDelete]
        [Route("Planeta")]
        public IHttpActionResult Excluir(Planeta planeta)
        {
            _planetaNg.Deletar(planeta);
            return Ok();
        }
    }
}
