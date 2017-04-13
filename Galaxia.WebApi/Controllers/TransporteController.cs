using Galaxia.Dominio;
using Galaxia.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Galaxia.WebApi.Controllers
{
    [RoutePrefix("api/v1")]
    public class TransporteController : ApiController
    {
        TransporteNG _transporteNG;
        public TransporteController()
        {
            _transporteNG = new TransporteNG();
        }
        [HttpGet]
        [Route("Transporte")]
        public IHttpActionResult Selecionar()
        {
            var retorno = _transporteNG.Selecionar();
            return Ok(retorno);
        }

        [HttpGet]
        [Route("Transporte/{id}")]
        public IHttpActionResult SelecionarPorId(int id)
        {
            var retorno = _transporteNG.SelecionarPorId(id);
            return Ok(retorno);
        }

        [HttpPost]
        [Route("Transporte")]
        public IHttpActionResult Incluir(Transporte transporte)
        {
            return Created(Request.RequestUri + "/" + transporte.Id, transporte);
        }

        [HttpPut]
        [Route("Transporte")]
        public IHttpActionResult Alterar(Transporte transporte)
        {
            return Content(HttpStatusCode.Accepted, transporte);
        }

        [HttpDelete]
        [Route("Transporte")]
        public IHttpActionResult Excluir(Transporte transporte)
        {
            return Ok();
        }
    }
}
