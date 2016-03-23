using Projeto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Aplicacao.Contracts
{
    public interface IAppServiceFuncionario
        : IAppServiceBase<Funcionario, Int32>
    {

    }
}
