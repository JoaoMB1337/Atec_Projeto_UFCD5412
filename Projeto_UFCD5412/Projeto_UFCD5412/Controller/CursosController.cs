using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_UFCD5412.Controller
{
    internal class CursosController
    {
        private List<string> cursos;

        public CursosController()
        {
            cursos = new List<string>();
            // Inicializa a lista de cursos chamando o método GestaoCursos
            GestaoCursos();
        }

        public List<string> ListarCursos()
        {
            return cursos;
        }

        // Método para adicionar cursos à lista
        private void GestaoCursos()
        {
            // Adiciona os cursos à lista
            cursos.Add("UFCD 5412");
            cursos.Add("UFCD 5413");
            cursos.Add("UFCD 5414");
            cursos.Add("UFCD 5415");
            // Adicione os demais cursos aqui...
        }
    }
}