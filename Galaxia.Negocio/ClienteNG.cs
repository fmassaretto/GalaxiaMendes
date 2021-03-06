﻿using Galaxia.Dominio.Interface;
using Galaxia.Dominio;
using System;
using System.Collections.Generic;
using Galaxia.Dados.Repositorio;

namespace Galaxia.Negocio
{
    public class ClienteNG : IRepositorioBase<Cliente>
    {
        private RepositorioBase<Cliente> _repositorio;
        public ClienteNG()
        {
            _repositorio = new RepositorioBase<Cliente>();
        }
        public void Alterar(Cliente obj)
        {
            _repositorio.Alterar(obj);
        }

        public void Deletar(Cliente obj)
        {
            _repositorio.Deletar(obj);
        }

        public void Incluir(Cliente obj)
        {
            _repositorio.Incluir(obj);
        }

        public IEnumerable<Cliente> Selecionar()
        {
            return _repositorio.Selecionar();
        }

        public Cliente SelecionarPorId(int id)
        {
            return _repositorio.SelecionarPorId(id);
        }
    }
}
