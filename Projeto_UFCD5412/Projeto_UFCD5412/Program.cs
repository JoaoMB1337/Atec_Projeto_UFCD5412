﻿using Projeto_UFCD5412.Data;
using Projeto_UFCD5412.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Projeto_UFCD5412.View.Forms;
using Projeto_UFCD5412.View.LoginForms;
using System.Security.Cryptography.X509Certificates;
using Projeto_UFCD5412.Controller;
using Projeto_UFCD5412.View.CoordenacaoForms;
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
            Application.Run(new LoginForm());
        }
    }
}
