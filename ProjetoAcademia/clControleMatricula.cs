using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ProjetoAcademia
{
    internal class clControleMatricula
    {
        private cl_Conexao c = new cl_Conexao();

        // PREENCHER TODOS
        public DataTable PreencherTodos()
        {
            string sql = "SELECT tbMatricula.idMatricula AS 'Número da Matrícula', " +
                         "tbMatricula.dataMatricula AS 'Data da Matrícula', " +
                         "tbAluno.nomeAluno AS 'Nome do Aluno', " +
                         "tbTurma.descricao AS 'Descrição da Turma', " +
                         "tbMatricula.statusMatricula AS 'Status da Matrícula' " +
                         "FROM tbMatricula " +
                         "JOIN tbAluno ON tbMatricula.idAluno = tbAluno.idAluno " +
                         "JOIN tbTurma ON tbMatricula.idTurma = tbTurma.idTurma;";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }


        // CADASTRAR
        public string cadastrar(clMatricula matricula)
        {
            try
            {
                string sql = "INSERT INTO tbMatricula (dataMatricula, idAluno, idTurma, statusMatricula) " +
                             "VALUES (@DataMatricula, @IdAluno, @IdTurma, @statusMatricula);";

                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                cmd.Parameters.AddWithValue("@DataMatricula", matricula.DataMatricula.ToString("yyyy-MM-dd")); 
                cmd.Parameters.AddWithValue("@IdAluno", matricula.IdAluno);
                cmd.Parameters.AddWithValue("@IdTurma", matricula.IdTurma);
                cmd.Parameters.AddWithValue("@statusMatricula", matricula.StatusMatricula);

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
        public string alterar(clMatricula matricula)
        {
            try
            {
                string sql = "UPDATE tbMatricula SET " +
                             "dataMatricula = @DataMatricula, " +
                             "idAluno = @IdAluno, " +
                             "idTurma = @IdTurma " +
                             "statusMatricula = @statusMatricula" +
                             "WHERE idMatricula = @IdMatricula;";

                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                cmd.Parameters.AddWithValue("@DataMatricula", matricula.DataMatricula.ToString("yyyy-MM-dd")); 
                cmd.Parameters.AddWithValue("@IdAluno", matricula.IdAluno);
                cmd.Parameters.AddWithValue("@IdTurma", matricula.IdTurma);
                cmd.Parameters.AddWithValue("@IdMatricula", matricula.IdMatricula);
                cmd.Parameters.AddWithValue("@statusMatricula", matricula.StatusMatricula);

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
        public clMatricula consultar(int IdMatricula)
        {
            clMatricula cont = null;

            try
            {
                string sql = "SELECT * FROM tbMatricula WHERE idMatricula = @IdMatricula;";

                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                cmd.Parameters.AddWithValue("@IdMatricula", IdMatricula);

                c.conectar();
                MySqlDataReader objDados = cmd.ExecuteReader();

                if (objDados.Read())
                {
                    cont = new clMatricula();
                    cont.IdMatricula = Convert.ToInt32(objDados["idMatricula"]);
                    cont.IdTurma = Convert.ToInt32(objDados["idTurma"]);
                    if (objDados["dataMatricula"] != DBNull.Value)
                    {
                        cont.DataMatricula = Convert.ToDateTime(objDados["dataMatricula"]);
                    }
                    cont.IdAluno = Convert.ToInt32(objDados["idAluno"]);
                    cont.StatusMatricula = objDados["statusMatricula"].ToString();
                }

                objDados.Close();
                c.desconectar();

                return cont;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}
