using System.Web.Http;

using Galaxia.Negocio;

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
    }
}
