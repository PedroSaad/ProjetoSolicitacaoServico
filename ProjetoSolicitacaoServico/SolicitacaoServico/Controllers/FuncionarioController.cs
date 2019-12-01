using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Repository;

namespace SolicitacaoServico.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly FuncionarioDAO _funcionarioDAO;
        public FuncionarioController(FuncionarioDAO funcionarioDAO)
        {
            _funcionarioDAO = funcionarioDAO;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            Funcionario f = new Funcionario();
            if (TempData["Funcionario"] != null)
            {
                f = JsonConvert.DeserializeObject<Funcionario>(TempData["Funcionario"].ToString());
            }
            return View(f);
        }

        [HttpPost]
        public IActionResult BuscarCep(Funcionario f)
        {
            try
            {
                //Arrumar ...
                string url = "https://viacep.com.br/ws/" + f.Endereco.Cep + "/json/";
                WebClient funci = new WebClient();
                f.Endereco = JsonConvert.DeserializeObject<Endereco>(funci.DownloadString(url));
                TempData["Funcionario"] = JsonConvert.SerializeObject(f);
            }
            catch (Exception)
            {
                //Mostrar uma mensagem para o usuário
            }
            return RedirectToAction("Cadastrar");
        }

        [HttpPost]
        public IActionResult Cadastrar(Funcionario f)
        {
            if (ModelState.IsValid)
            {
                if (_funcionarioDAO.Cadastrar(f))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("","Esse e-mail já está sendo usado!");
            }
            return View(f);
        }
    }
}