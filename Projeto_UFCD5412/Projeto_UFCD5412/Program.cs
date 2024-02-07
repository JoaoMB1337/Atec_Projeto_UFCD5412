using Projeto_UFCD5412.Data;
using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Projeto_UFCD5412.Data;
using System.Runtime.CompilerServices;
using Projeto_UFCD5412.View.Forms;
using Projeto_UFCD5412.View.LoginForms;
namespace Projeto_UFCD5412
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {       
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new MainWindow());
            Application.Run(new LoginForm());



        }
    }
}
