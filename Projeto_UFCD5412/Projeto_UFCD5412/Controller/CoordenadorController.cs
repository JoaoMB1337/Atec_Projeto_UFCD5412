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

        public void EditarFormacao(Formacao formacaoOriginal, Formacao formacaoEditada)
        {
            int index = Formacaos.FindIndex(f => f.Equals(formacaoOriginal));
            if (index != -1)
            {
                Formacaos[index] = formacaoEditada;
                CSVFormacao.ExportToCSV(Formacaos);
                Console.WriteLine("Formação editada com sucesso no arquivo CSV.");
            }
            else
            {
                Console.WriteLine("Formação original não encontrada.");
            }
        }

        public List<Formacao> ListarFormacoes()
        {
            return Formacaos;
        }



    }
}
 