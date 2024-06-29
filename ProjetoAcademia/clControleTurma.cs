using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ProjetoAcademia
{
    internal class clControleTurma
    {
        cl_Conexao c = new cl_Conexao();

        // PREENCHER TODOS
        public DataTable PreencherTodos()
        {
            string sql = "SELECT tbTurma.idTurma AS 'Número da Turma', tbTurma.descricao AS 'Descrição', tbTurma.horarioInicio AS 'Horário de Início', tbTurma.horarioTermino AS 'Horário de Fim', tbProfessor.nome AS 'Nome do Professor', tbTurma.statusTurma AS 'Status da Turma' FROM tbTurma JOIN tbProfessor ON tbTurma.idProfessor = tbProfessor.idProfessor;";
            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        // CADASTRAR
        public string cadastrar(clTurma turma)
        {
            try
            {
                string sql = "INSERT INTO tbTurma (descricao, horarioInicio, horarioTermino, IdProfessor, statusTurma) " +
                             "VALUES (@Descricao, @HorarioInicio, @HorarioTermino, @IdProfessor, @statusTurma);";

                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                cmd.Parameters.AddWithValue("@Descricao", turma.Descricao);
                cmd.Parameters.AddWithValue("@HorarioInicio", turma.Horarioinicio);
                cmd.Parameters.AddWithValue("@HorarioTermino", turma.Horariotermino);
                cmd.Parameters.AddWithValue("@IdProfessor", turma.IdProfessor);
                cmd.Parameters.AddWithValue("@statusTurma", turma.StatusTurma);

                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return "Cadastro realizado com sucesso!";
            }
            catch (MySqlException e)
            {
                return e.ToString();
            }
        }

        // ALTERAR
        public string alterar(clTurma turma)
        {
            try
            {
                string sql = "UPDATE tbTurma SET descricao = @Descricao, horarioInicio = @HorarioInicio, " +
                             "horarioTermino = @HorarioTermino, IdProfessor = @IdProfessor, StatusTurma = @statusTurma WHERE idTurma = @IdTurma;";

                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                cmd.Parameters.AddWithValue("@Descricao", turma.Descricao);
                cmd.Parameters.AddWithValue("@HorarioInicio", turma.Horarioinicio);
                cmd.Parameters.AddWithValue("@HorarioTermino", turma.Horariotermino);
                cmd.Parameters.AddWithValue("@IdProfessor", turma.IdProfessor);
                cmd.Parameters.AddWithValue("@IdTurma", turma.IdTurma);

                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return "Atualização realizada com sucesso!";
            }
            catch (MySqlException e)
            {
                return e.ToString();
            }
        }

        // CONSULTAR
        public clTurma consultar(int IdTurma)
        {
            clTurma cont = new clTurma();

            try
            {
                string sql = "SELECT * FROM tbTurma WHERE idTurma = @IdTurma;";
                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                cmd.Parameters.AddWithValue("@IdTurma", IdTurma);
                c.conectar();

                MySqlDataReader objDados = cmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    return null;
                }
                else
                {
                    objDados.Read();
                    cont.IdTurma = Convert.ToInt32(objDados["idTurma"]);
                    cont.IdProfessor = Convert.ToInt32(objDados["idProfessor"]);
                    cont.Horariotermino = objDados.GetTimeSpan(objDados.GetOrdinal("horarioTermino"));
                    cont.Horarioinicio = objDados.GetTimeSpan(objDados.GetOrdinal("horarioInicio"));
                    cont.Descricao = objDados["descricao"].ToString();
                    cont.StatusTurma = objDados["statusTurma"].ToString();

                    objDados.Close();
                    return cont;
                }
            }
            catch (MySqlException e)
            {
                throw e;
            }
            finally
            {
                c.desconectar();
            }
        }

    }
}
