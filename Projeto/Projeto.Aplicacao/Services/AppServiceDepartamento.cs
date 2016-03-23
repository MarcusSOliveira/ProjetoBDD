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
    public class AppServiceDepartamento : AppServiceBase<Departamento, Int32>,
        IAppServiceDepartamento
    {
        //atributo..
        private IDomainServiceDepartamento dominio;

        //construtor..
        public AppServiceDepartamento(IDomainServiceDepartamento dominio)
            : base(dominio)
        {
            this.dominio = dominio;
        }

    }
}
