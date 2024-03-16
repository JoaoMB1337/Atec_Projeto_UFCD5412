using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_UFCD5412.Data;
using System.Windows;

namespace Projeto_UFCD5412.Controller
{
    internal class CoordenadorController
    {
        public List<Formacao> Formacaos { get; set; }
        private static CoordenadorController instance;
        private static readonly object lockObject = new object();

        public CoordenadorController()
        {
            Formacaos = CSVFormacao.LoadFromCSV();
        }

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


        #region Formacao Editar, Adicionar, Remover
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

        public void RemoverFormacao(Formacao formacao)
        {
            Formacaos.Remove(formacao);
            CSVFormacao.ExportToCSV(Formacaos);
        }

        #endregion


        #region Listar Formaçoes

        public List<Formacao> ListarFormacoes()
        {
            return Formacaos;
        }

        #endregion

    }
}
