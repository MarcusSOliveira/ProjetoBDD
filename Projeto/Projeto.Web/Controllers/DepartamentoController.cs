using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Web.Models;
using Projeto.Aplicacao.Contracts;
using Projeto.Entidades;

namespace Projeto.Web.Controllers
{
    public class DepartamentoController : Controller
    {
        private IAppServiceDepartamento appDepartamento;

        //ninject passado no contrutor para injeção de dependencia
        public DepartamentoController( IAppServiceDepartamento appDepartamento)
        {
            this.appDepartamento = appDepartamento;
        }

        // GET: Departamento/Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }

        // httpPost: Departamento/Cadastro
        [HttpPost]
        public ActionResult Cadastro(DepartamentoViewModelCadastro model)
        {
            if (ModelState.IsValid)
            {
                var d = new Departamento();
                d.Nome = model.Nome;

                try
                {
                    appDepartamento.Cadastrar(d);
                    ViewBag.Mensagem = "Departamento cadastrado com sucesso";
                    ModelState.Clear(); //Limpar a model

                }
                catch (Exception e)
                {
                    ViewBag.Mensagem = e.Message;                    
                }
            }
            return View();
        }
    }
}