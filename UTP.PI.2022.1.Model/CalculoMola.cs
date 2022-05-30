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
    public class CalculoMola
    {
        [DisplayName("Equipe")]
        public string EQUIPE { get; set; }

        [DisplayName("Roda")]
        public int RODA { get; set; }

        [DisplayName("Peso na Roda")]
        public float PESO_RODA { get; set; }

        [DisplayName("Distância Ponta de Eixo")]
        public float DISTANCIA_EIXO { get; set; }

        [DisplayName("Distância do Apoio")]
        public float DISTANCIA_APOIO { get; set; }

        [DisplayName("Constante (N/m)")]
        public float CONSTANTE { get; set; }

        [DisplayName("Data do Cálculo")]
        public DateTime DATA { get; set; }

        public static List<CalculoMola> BuscarTodasEquipe(string EQUIPE)
        {
            var lst = new List<CalculoMola>();

            using (var conn = DataBase.CriarConexao())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = "SELECT RODA, EQUIPE, PESO_RODA, DISTANCIA_EIXO, DISTANCIA_APOIO, CONSTANTE, DATA FROM tb_CalcMola WHERE EQUIPE = @EQUIPE";

                    command.Parameters.Add(new SqliteParameter("@EQUIPE", EQUIPE));

                    using (var dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lst.Add(new CalculoMola
                            {
                                RODA = dr.GetInt32(0),
                                EQUIPE = dr.GetString(1),
                                PESO_RODA = dr.GetFloat(2),
                                DISTANCIA_EIXO = dr.GetFloat(3),
                                DISTANCIA_APOIO = dr.GetFloat(4),
                                CONSTANTE = dr.GetFloat(5),
                                DATA = dr.GetDateTime(6),

                            });
                        }
                    }
                    return lst;
                }
            }
        }
        public void Salvar()
        {
            using (var conn = DataBase.CriarConexao())
            {
                conn.Open();

                var sql = new StringBuilder();


                SqliteCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO tb_CalcMola (EQUIPE, RODA, PESO_RODA, DISTANCIA_EIXO, DISTANCIA_APOIO, CONSTANTE, DATA) VALUES (@EQUIPE,@RODA,@PESO_RODA,@DISTANCIA_EIXO,@DISTANCIA_APOIO,@CONSTANTE, @DATA)";

                command.Parameters.Add(new SqliteParameter("@EQUIPE", EQUIPE));
                command.Parameters.Add(new SqliteParameter("@RODA", RODA));
                command.Parameters.Add(new SqliteParameter("@PESO_RODA", PESO_RODA));
                command.Parameters.Add(new SqliteParameter("@DISTANCIA_EIXO", DISTANCIA_EIXO));
                command.Parameters.Add(new SqliteParameter("@DISTANCIA_APOIO", DISTANCIA_APOIO));
                command.Parameters.Add(new SqliteParameter("@CONSTANTE", CONSTANTE));
                command.Parameters.Add(new SqliteParameter("@DATA", DateTime.Now));


                command.ExecuteNonQuery();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql.ToString();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
