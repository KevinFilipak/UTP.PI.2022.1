using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTP.PI._2022._1.Model.Config
{
    public static class DataBase
    {
        /// <summary>
        /// Metodo de Criação de DataBase
        /// </summary>
        /// <param name="nome">Nome do Arquivo a ser utilizado. Passar com extensão .sqlite</param>
        public static void CriarArquivo(string nome)
        {


            using (var connection = new SqliteConnection("Data Source=" + nome + ".db"))
            {
                connection.Open(); 

                SqliteCommand cmd = connection.CreateCommand();

                cmd.CommandText = "CREATE TABLE Banco ([Id] INTEGER PRIMARY KEY, [Nome] VARCHAR(100));";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE Agencia ([Id] INTEGER PRIMARY KEY, [Nome] VARCHAR(100), [Endereco] VARCHAR(100), [CodigoBanco] INTEGER);";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE Cliente ([Id] INTEGER PRIMARY KEY, [Nome] VARCHAR(100), [CPF] VARCHAR(100), [Email] VARCHAR(100), [Telefone] VARCHAR(100));";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE Conta ([Id] INTEGER PRIMARY KEY, [NumeroConta] VARCHAR(100), [CodigoAgencia] INTEGER, [CodigoCliente] INTEGER, [Limite] FLOAT, [Saldo] FLOAT);";
                cmd.ExecuteNonQuery();

                cmd.Dispose();

                connection.Close();
                connection.Dispose();

            }


          




        }
    }
}
