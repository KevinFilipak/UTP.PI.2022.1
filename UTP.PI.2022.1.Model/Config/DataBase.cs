﻿using Microsoft.Data.Sqlite;
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

        private static string nome_db;
        /// <summary>
        /// Metodo de Criação de DataBase
        /// </summary>
        /// <param name="nome">Nome do Arquivo a ser utilizado. Passar com extensão .sqlite</param>
        public static void CriarArquivo(string nome)
        {
            nome_db = nome;
            if (!File.Exists(nome + ".db"))
            {
                using (var connection = new SqliteConnection("Data Source=" + nome_db + ".db"))
                {
                    connection.Open();

                    SqliteCommand cmd = connection.CreateCommand();

                    cmd.CommandText = "CREATE TABLE tb_Equipe " +
                                      "([ID] INTEGER PRIMARY KEY, " +
                                      "[EQUIPE] VARCHAR(50), " +
                                      "[COL1] VARCHAR(50)," +
                                      "[COL2] VARCHAR(50)," +
                                      "[COL3] VARCHAR(50)," +
                                      "[COL4] VARCHAR(50)," +
                                      "[Senha] VARCHAR(10), " +
                                      "[CREATED] DATETIME, " +
                                      "[UPDATED] DATETIME, " +
                                      "[ARCHIVED] DATETIME);";
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();

                    connection.Close();
                    connection.Dispose();

                }
            }

        }
        public static SqliteConnection CriarConexao()
        {
            
           return  new SqliteConnection("Data Source=" + nome_db + ".db");
            

        }
    }
}