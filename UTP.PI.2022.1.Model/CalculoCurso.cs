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
    public class CalculoCurso
    {

        [DisplayName("Equipe")]
        public string EQUIPE { get; set; }

        [DisplayName("Roda")]
        public int RODA { get; set; }

        [DisplayName("Distância do chão")]
        public float DISTANCIA_CHAO { get; set; }

        [DisplayName("Comprimento do Triângulo da Suspensão")]
        public float DISTANCIA_TRIANGULO { get; set; }

        [DisplayName("Constante (°)")]
        public double CONSTANTE { get; set; }

        [DisplayName("Data do Cálculo")]
        public DateTime DATA { get; set; }

        public static List<CalculoCurso> BuscarTodasEquipe(string EQUIPE)
        {
            var lst = new List<CalculoCurso>();

            using (var conn = DataBase.CriarConexao())
            {
                conn.Open();

                using (var command = conn.CreateCommand())
                {
                    command.CommandText = "SELECT RODA, DISTANCIA_CHAO, DISTANCIA_CHAO, CONSTANTE, DATA FROM tb_CalcCurso WHERE EQUIPE = @EQUIPE";

                    command.Parameters.Add(new SqliteParameter("@EQUIPE", EQUIPE));

                    using (var dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lst.Add(new CalculoCurso
                            {
                                RODA = dr.GetInt32(0),
                                DISTANCIA_CHAO = dr.GetFloat(1),
                                DISTANCIA_TRIANGULO = dr.GetFloat(2),
                                CONSTANTE = dr.GetFloat(4),
                                DATA = dr.GetDateTime(5),

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
                command.CommandText = "INSERT INTO tb_CalcCurso (EQUIPE, RODA, DISTANCIA_CHAO, DISTANCIA_TRIANGULO, CONSTANTE, DATA) VALUES (@EQUIPE,@RODA,@DISTANCIA_CHAO,@DISTANCIA_TRIANGULO,@CONSTANTE, @DATA)";

                command.Parameters.Add(new SqliteParameter("@EQUIPE", EQUIPE));
                command.Parameters.Add(new SqliteParameter("@RODA", RODA));
                command.Parameters.Add(new SqliteParameter("@DISTANCIA_CHAO", DISTANCIA_CHAO));
                command.Parameters.Add(new SqliteParameter("@DISTANCIA_TRIANGULO", DISTANCIA_TRIANGULO));
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
