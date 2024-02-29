using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_UFCD5412.Data;

namespace Projeto_UFCD5412.Controller
{
    internal class CoordenadorController
    {
        private static CoordenadorController instance;
        private static readonly object lockObject = new object();
        public static CoordenadorController Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new CoordenadorController();
                    }
                    return instance;
                }
            }
        }

        public List<Formacao> Formacaos { get; set; }

        public CoordenadorController()
        {
            Formacaos = CSVFormacao.LoadFromCSV();
        }

        public void AdicionarFormacao(Formacao formacao)
        {
            Formacaos.Add(formacao);
            CSVFormacao.AdicionarFormacao(formacao);
        }

        public List<Formacao> ListarFormacoes()
        {
            return Formacaos;
        }

    }
}
 