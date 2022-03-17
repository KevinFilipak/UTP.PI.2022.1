using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTP.PI._2022._1.Model.Config;

namespace UTP.PI._2022._1.Model
{
    public class Equipe
    {

        [DisplayName("Código")]
        public int ID { get; set; }

        [DisplayName("Equipe")]
        public string EQUIPE { get; set; }

        [DisplayName("Colaborador 1")]
        public string COL1 { get; set; }

        [DisplayName("Colaborador 2")]
        public string COL2 { get; set; }

        [DisplayName("Colaborador 3")]
        public string COL3 { get; set; }

        [DisplayName("Colaborador 4")]
        public string COL4 { get; set; }

        [DisplayName("Senha")]
        public string SENHA { get; set; }




        public static List<Equipe> BuscarTodas()
        {
            var lst = new List<Equipe>();

            using (var conn = DataBase.CriarConexao())
            {
                conn.Open();
                var sql = new StringBuilder();
                sql.AppendLine("SELECT *" +
                    "             FROM tb_Equipe" +
                    "            WHERE ARCHIVED IS NULL;");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lst.Add(new Equipe
                            {
                                ID = 0000 + dr.GetInt32(0),
                                EQUIPE = dr.GetString(1),
                                COL1 = dr.GetString(2),
                                COL2 = dr.GetString(3),
                                COL3 = dr.GetString(4),
                                COL4 = dr.GetString(5),
                                SENHA = "******"

                            });
                        }
                    }
                }
            }
            return lst;
        }

        public void Inserir()
        {
            using (var conn = DataBase.CriarConexao())
            {
                conn.Open();

                var sql = new StringBuilder();


                SqliteCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO tb_Equipe (EQUIPE, COL1, COL2, COL3, COL4, SENHA) VALUES ('@EQUIPE','@COL1','@COL2','@COL3','@COL4', '@SENHA')";

                command.Parameters.Add(new SqliteParameter("@EQUIPE", EQUIPE));
                command.Parameters.Add(new SqliteParameter("@COL1", COL1));
                command.Parameters.Add(new SqliteParameter("@COL2", COL2));
                command.Parameters.Add(new SqliteParameter("@COL3", COL3));
                command.Parameters.Add(new SqliteParameter("@COL4", COL4));
                command.Parameters.Add(new SqliteParameter("@SENHA", SENHA));
                command.ExecuteNonQuery();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar()
        {
            using (var conn = DataBase.CriarConexao())
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("UPDATE tb_Equipe ");
                sql.AppendLine("(EQUIPE, COL1, COL2, COL3, COL4, SENHA) VALUES ");
                sql.AppendLine($"('{this.EQUIPE}'");
                sql.AppendLine($",'{this.COL1}'");
                sql.AppendLine($",'{this.COL2}'");
                sql.AppendLine($",'{this.COL3}'");
                sql.AppendLine($",'{this.COL4}'");
                sql.AppendLine($",'{this.SENHA}'");


                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir()
        {
            using (var conn = DataBase.CriarConexao())
            {
                conn.Open();

                var sql = new StringBuilder();

                sql.AppendLine("UPDATE tb_Equipe ");
                sql.AppendLine("SET ARCHIVED = GETDATE() WHERE ID = ");
                sql.AppendLine($"('{this.ID}'");

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
