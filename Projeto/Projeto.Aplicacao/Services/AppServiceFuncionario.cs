using Projeto.Aplicacao.Contracts;
using Projeto.Dominio.DomainContracts.Services;
using Projeto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Aplicacao.Services
{
    public class AppServiceFuncionario : AppServiceBase<Funcionario, Int32>,
        IAppServiceFuncionario
    {
        //atributo..
        private IDomainServiceFuncionario dominio;

        //construtor..
        public AppServiceFuncionario(IDomainServiceFuncionario dominio)
            : base(dominio)
        {
            this.dominio = dominio;
        }

    }
}
