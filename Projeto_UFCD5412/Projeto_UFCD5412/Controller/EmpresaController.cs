using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412
{
    internal class EmpresaController
    {
        public List<Funcionario> Funcionarios { get; set; }

        public EmpresaController()
        {
            Funcionarios = new List<Funcionario>();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        
    }
}
