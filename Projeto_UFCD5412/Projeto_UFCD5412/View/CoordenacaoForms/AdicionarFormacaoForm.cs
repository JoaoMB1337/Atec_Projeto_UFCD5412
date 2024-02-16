using Projeto_UFCD5412.Controller;
using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_UFCD5412.View.CoordenacaoForms
{
    public partial class AdicionarFormacaoForm : Form
    {
        //Variáveis data inicio e fim de formacao, hora inicio e fim de formacao, formador, curso.
        private DateTime dataInicio;
        private DateTime dataFim;
        private DateTime horaInicio;
        private DateTime horaFim;
        private string formador;
        private string curso;

        public AdicionarFormacaoForm()
        {
            InitializeComponent();
        }

        public object GestaoCursos { get; private set; }

        private void AdicionarFormacaoForm_Load(object sender, EventArgs e)
        {
            //Carregar formadores
            FormadoresController formadoresController = new FormadoresController(GestaoFormadores.ObterFuncionarios());
            List<string> formadores = formadoresController.ListarFormadores();
            Fomadores_Combo.Items.AddRange(formadores.ToArray());

            // Criar uma instância de CursosController
            CursosController cursosController = new CursosController();
            // Obter a lista de cursos
            List<string> cursos = cursosController.ListarCursos();
            // Adicionar os cursos à ComboBox
            Turmas_Combo.Items.AddRange(cursos.ToArray());
        }





    }
}