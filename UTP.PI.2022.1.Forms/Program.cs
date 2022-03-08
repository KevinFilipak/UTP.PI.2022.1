using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UTP.PI._2022._1.Forms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            if (!File.Exists("DB.sqlite"))
            {

                SqliteConnection conn = new SqliteConnection("Data Source=DB.sqlite");

                conn.Open();

                SqliteCommand cmd = conn.CreateCommand();

                cmd.CommandText = "CREATE TABLE Banco ([Id] INTEGER PRIMARY KEY, [Nome] VARCHAR(100));";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE Agencia ([Id] INTEGER PRIMARY KEY, [Nome] VARCHAR(100), [Endereco] VARCHAR(100), [CodigoBanco] INTEGER);";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE Cliente ([Id] INTEGER PRIMARY KEY, [Nome] VARCHAR(100), [CPF] VARCHAR(100), [Email] VARCHAR(100), [Telefone] VARCHAR(100));";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE Conta ([Id] INTEGER PRIMARY KEY, [NumeroConta] VARCHAR(100), [CodigoAgencia] INTEGER, [CodigoCliente] INTEGER, [Limite] FLOAT, [Saldo] FLOAT);";
                cmd.ExecuteNonQuery();

                cmd.Dispose();

                conn.Close();
                conn.Dispose();
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
