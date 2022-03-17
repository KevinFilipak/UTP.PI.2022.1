using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTP.PI._2022._1.Model;
using UTP.PI._2022._1.Model.Config;

namespace UTP.PI._2022._1.Forms
{
    static class Program
    {
        public static Equipe EquipeLogada = new Equipe();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string nome = ConfigurationManager.AppSettings["DataBaseName"];
            DataBase.CriarArquivo(nome);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();

            if (frmLogin.Validar) {

                Application.Run(new frmPrincipal());

            }
            else
            {
                Application.Exit(); 
            }

        }
    }
}
