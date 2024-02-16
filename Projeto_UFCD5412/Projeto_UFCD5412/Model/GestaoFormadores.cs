using Projeto_UFCD5412.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412.Model
{
    internal class GestaoFormadores //esta classe serve para gerir os formadores , aloca-los a cursos e disciplinas , respetivos horarios de formacao.
    {
        public static List<Funcionario> Funcionarios { get; internal set; }

        public static List<Funcionario> ObterFuncionarios()
        {
            return EmpresaController.Instance.ListarFuncionarios();
            
        }

       


    }
}
