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
    public class ClienteController : ApiController
    {
        ClienteNG _clienteNG;
        public ClienteController()
        {
            _clienteNG = new ClienteNG();
        }

        [HttpPost]
        [Route("Cliente")]
        public IHttpActionResult Inserir(Cliente cliente)
        {
            _clienteNG.Incluir(cliente);
            return Created(Request.RequestUri + "/" + cliente.Id, cliente);
        }

        [HttpPut]
        [Route("Cliente")]
        public IHttpActionResult Alterar(Cliente cliente)
        {
            _clienteNG.Alterar(cliente);
            return Content(HttpStatusCode.Accepted,cliente);
        }

        [HttpDelete]
        [Route("Cliente")]
        public IHttpActionResult Excluir(Cliente cliente)
        {
            _clienteNG.Deletar(cliente);
            return Ok();
        }

        [HttpGet]
        [Route("Cliente")]
        public IHttpActionResult Selecionar()
        {
            var retorno = _clienteNG.Selecionar();
            return Ok(retorno);
        }

        [HttpGet]
        [Route("Cliente/{id}")]
        public IHttpActionResult SelecionarPorId(int id)
        {
            var retorno = _clienteNG.SelecionarPorId(id);
            return Ok(retorno);

        }
    }
}
