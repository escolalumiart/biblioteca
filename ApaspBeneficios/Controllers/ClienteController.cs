using EscolaLumiart.Models.Dtos;
using EscolaLumiart.Models.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaLumiart.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            try
            {
                var clientes = _clienteService.Listar();
                return View(clientes);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Nome, Cpf, Email, Fone")] ClienteDto cliente)
        {
            try
            {

                _clienteService.Cadastrar(cliente);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public IActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var cliente = _clienteService.PesquisarPorId(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id, Nome, Cpf, Email, Fone")] ClienteDto cliente)
        {
            if (string.IsNullOrEmpty(cliente.Id))
            {
                return NotFound();
            }
            try
            {
                _clienteService.Atualizar(cliente);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public IActionResult Details(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var cliente = _clienteService.PesquisarPorId(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        public IActionResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var cliente = _clienteService.PesquisarPorId(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([Bind("Id, Nome, Cpf, Email, Fone")] ClienteDto cliente)
        {
            if (string.IsNullOrEmpty(cliente.Id))
            {
                return NotFound();
            }
            try
            {
                _clienteService.Excluir(cliente.Id);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}

