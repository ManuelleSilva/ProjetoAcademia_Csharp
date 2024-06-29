using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ProjetoAcademia
{
    internal class ClControleProfessor
    {
        cl_Conexao c = new cl_Conexao();

        // PREENCHER TODOS
        public DataTable PreencherTodos()
        {
            string sql = "SELECT * FROM tbProfessor;";
            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        // CADASTRAR
        public string Cadastrar(clProfessor professor)
        {
            try
            {
                string sql = "INSERT INTO tbProfessor(nome, telefone, celular, emailpf, senhapf, statusProfessor) " +
                             "VALUES (@Nome, @Telefone, @Celular, @Email, @Senha, @StatusProfessor);";

                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                cmd.Parameters.AddWithValue("@Nome", professor.Nome);
                cmd.Parameters.AddWithValue("@Telefone", professor.Tel);
                cmd.Parameters.AddWithValue("@Celular", professor.Cel);
                cmd.Parameters.AddWithValue("@Email", professor.Email);
                cmd.Parameters.AddWithValue("@Senha", professor.Senha);
                cmd.Parameters.AddWithValue("@StatusProfessor", professor.StatusProfessor);

                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return "Cadastro realizado com sucesso!";
            }
            catch (MySqlException e)
            {
                return "Erro ao cadastrar professor: " + e.Message;
            }
        }

        // ALTERAR
        public string Alterar(clProfessor professor)
        {
            try
            {
                string sql = "UPDATE tbProfessor SET " +
                             "nome = @Nome, " +
                             "telefone = @Telefone, " +
                             "celular = @Celular, " +
                             "emailpf = @Email, " +
                             "senhapf = @Senha, " +
                             "statusProfessor = @StatusProfessor " +
                             "WHERE idProfessor = @IdProfessor;";

                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                cmd.Parameters.AddWithValue("@Nome", professor.Nome);
                cmd.Parameters.AddWithValue("@Telefone", professor.Tel);
                cmd.Parameters.AddWithValue("@Celular", professor.Cel);
                cmd.Parameters.AddWithValue("@Email", professor.Email);
                cmd.Parameters.AddWithValue("@Senha", professor.Senha);
                cmd.Parameters.AddWithValue("@StatusProfessor", professor.StatusProfessor);
                cmd.Parameters.AddWithValue("@IdProfessor", professor.IdProfessor);

                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return "Atualização realizada com sucesso";
            }
            catch (MySqlException e)
            {
                return "Erro ao alterar professor: " + e.Message;
            }
        }

        // CONSULTAR
        public clProfessor Consultar(int idProfessor)
        {
            clProfessor professor = new clProfessor();

            try
            {
                string sql = "SELECT * FROM tbProfessor WHERE idProfessor = @IdProfessor;";
                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                cmd.Parameters.AddWithValue("@IdProfessor", idProfessor);

                c.conectar();
                MySqlDataReader objDados = cmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    return null;
                }
                else
                {
                    objDados.Read();
                    professor.IdProfessor = Convert.ToInt32(objDados["idProfessor"]);
                    professor.Nome = objDados["nome"].ToString();
                    professor.Tel = objDados["telefone"].ToString();
                    professor.Cel = objDados["celular"].ToString();
                    professor.Email = objDados["emailpf"].ToString();
                    professor.Senha = objDados["senhapf"].ToString();
                    professor.StatusProfessor = objDados["statusProfessor"].ToString();

                    objDados.Close();
                    return professor;
                }
            }
            catch (MySqlException e)
            {
                throw new Exception("Erro ao consultar professor: " + e.Message);
            }
            finally
            {
                c.desconectar();
            }
        }
    }
}
