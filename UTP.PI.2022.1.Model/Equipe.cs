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

        [DisplayName("Administrador")]
        public bool ADMIN { get; set; }




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
                                ID = dr.GetInt32(0),
                                EQUIPE = dr.GetString(1),
                                COL1 = dr.GetString(2),
                                COL2 = dr.GetString(3),
                                COL3 = dr.GetString(4),
                                COL4 = dr.GetString(5),
                                SENHA = dr.GetString(6),
                                ADMIN = dr.GetBoolean(7),
                            });
                        }
                    }
                }
            }
            return lst;
        }

        public string Salvar()
        {
            try
            {
                if (this.ID == 0)
                {
                    this.Inserir();
                    return "Equipe Cadastrada!";
                }
                else
                {
                    this.Atualizar();
                    return "Equipe Atualizada!";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void Inserir()
        {
            using (var conn = DataBase.CriarConexao())
            {
                conn.Open();

                var sql = new StringBuilder();


                SqliteCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO tb_Equipe (EQUIPE, COL1, COL2, COL3, COL4, SENHA, ADMIN, CREATED) VALUES (@EQUIPE,@COL1,@COL2,@COL3,@COL4,@SENHA,@ADMIN,DATETIME('now'))";

                command.Parameters.Add(new SqliteParameter("@EQUIPE", EQUIPE)) ;
                command.Parameters.Add(new SqliteParameter("@COL1", COL1));
                command.Parameters.Add(new SqliteParameter("@COL2", COL2));
                command.Parameters.Add(new SqliteParameter("@COL3", COL3));
                command.Parameters.Add(new SqliteParameter("@COL4", COL4));
                command.Parameters.Add(new SqliteParameter("@SENHA", SENHA));
                command.Parameters.Add(new SqliteParameter("@ADMIN", ADMIN));

                command.ExecuteNonQuery();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void Atualizar()
        {
            using (var conn = DataBase.CriarConexao())
            { 
                conn.Open();

                var sql = new StringBuilder();


                SqliteCommand command = conn.CreateCommand();
                command.CommandText = "UPDATE tb_Equipe SET EQUIPE = @EQUIPE, " +
                                                             "COL1 = @COL1," +
                                                             "COL2 = @COL2, " +
                                                             "COL3 = @COL3, " +
                                                             "COL4 = @COL4, " +
                                                             "UPDATED = DATETIME('now'), " +
                                                             "ADMIN = @ADMIN, " +
                                                             "SENHA = @SENHA WHERE ID = @ID ";

                command.Parameters.Add(new SqliteParameter("@ID", ID));
                command.Parameters.Add(new SqliteParameter("@EQUIPE", EQUIPE));
                command.Parameters.Add(new SqliteParameter("@COL1", COL1));
                command.Parameters.Add(new SqliteParameter("@COL2", COL2));
                command.Parameters.Add(new SqliteParameter("@COL3", COL3));
                command.Parameters.Add(new SqliteParameter("@COL4", COL4));
                command.Parameters.Add(new SqliteParameter("@SENHA", SENHA));
                command.Parameters.Add(new SqliteParameter("@ADMIN", ADMIN));


                command.ExecuteNonQuery();

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


                SqliteCommand command = conn.CreateCommand();
                command.CommandText = "UPDATE tb_Equipe SET ARCHIVED = DATETIME('now') WHERE ID = @ID ";

                command.Parameters.Add(new SqliteParameter("@ID", ID));

                command.ExecuteNonQuery();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool ValidarLogin()
        {
            using (var conn = DataBase.CriarConexao())
            {
                conn.Open();
         
                
               

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM tb_Equipe WHERE ARCHIVED IS NULL AND EQUIPE = @EQUIPE AND SENHA = @SENHA";

                    command.Parameters.Add(new SqliteParameter("@EQUIPE", EQUIPE));
                    command.Parameters.Add(new SqliteParameter("@SENHA", SENHA));


                    using (var dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            this.ID = dr.GetInt32(0);
                            this.EQUIPE = dr.GetString(1);
                            this.COL1 = dr.GetString(2);
                            this.COL2 = dr.GetString(3);
                            this.COL3 = dr.GetString(4);
                            this.COL4 = dr.GetString(5);
                            this.SENHA = dr.GetString(6);
                            this.ADMIN = dr.GetBoolean(7);

                        }
                    }
                }
            }

            return this.ID > 0;            
        }

    }
}
