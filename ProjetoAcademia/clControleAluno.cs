using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoAcademia
{
    class clControleAluno
    {

        cl_Conexao c = new cl_Conexao();

        public string cadastrar(clAluno aluno)
        {

            try
            {
                string sql = "insert into tbAluno(nomeAluno, cpf, endereco, bairro, cidade, estado, cep, telefone, celular, email, peso, altura, imc, statusAluno, obs, senha)" +
                   "values('" + aluno.NomeAluno + "', '" + aluno.Cpf + "', '" + aluno.Endereco + "', '" + aluno.Bairro + "' , '" + aluno.Cidade + "', '" + aluno.Estado + "', '" + aluno.Cep + "', '" + aluno.Tel + "', '" + aluno.Cel + "', '" + aluno.Email + "',  " + aluno.Peso.ToString().Replace(",", ".") + ", " + aluno.Altura.ToString().Replace(",",".") + ", " +Math.Round(aluno.Imc,2).ToString().Replace(",",".") + ", '" + aluno.StatusAluno + "', '" + aluno.Obs + "', '" + aluno.Senha + "');";


                MySqlCommand cmd = new MySqlCommand(sql, c.con);
                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return "Cadastro realizado com sucesso!";


            }
            catch (MySqlException e)
            {
                return (e.ToString());

            }
        }

        public DataTable PreencherTodos()
        {
            string sql = "select * from tbAluno ; ";
            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            c.conectar();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable contato = new DataTable();
            da.Fill(contato);
            c.desconectar();
            return contato;
        }

        public string excluir(clAluno cont)
        {
            try
            {
                string sql = "DELETE FROM tbAluno WHERE idAluno = " + cont.IdAluno + ";";

                MySqlCommand sqlcmd = new MySqlCommand(sql, c.con);

                //abrir conexão
                c.conectar();
                sqlcmd.ExecuteNonQuery();

                //fechar conexão
                c.desconectar();
                return ("Cadastro excluido com sucesso");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }

        public clAluno consultar(int IdAluno)
        {
            clAluno cont = new clAluno();

            try
            {
                string sql = "SELECT * FROM tbAluno WHERE idAluno= " + IdAluno + ";";

                MySqlCommand sqlcmd = new MySqlCommand(sql, c.con);
                c.conectar();

                MySqlDataReader objDados = sqlcmd.ExecuteReader();

                if (!objDados.HasRows) 
                {
                    return null;
                }
                else
                {
                    objDados.Read();
                    cont.IdAluno = Convert.ToInt32(objDados["idAluno"]);
                    cont.NomeAluno = objDados["nomeAluno"].ToString();
                    cont.Cpf = objDados["cpf"].ToString();
                    cont.Endereco = objDados["endereco"].ToString();
                    cont.Bairro = objDados["bairro"].ToString();
                    cont.Cidade = objDados["cidade"].ToString();
                    cont.Estado = objDados["estado"].ToString();
                    cont.Cep = objDados["cep"].ToString();
                    cont.Peso = Convert.ToDecimal(objDados["peso"]);
                    cont.Tel = objDados["telefone"].ToString();
                    cont.Cel = objDados["celular"].ToString();
                    cont.Email = objDados["email"].ToString();
                    cont.Altura = Convert.ToDecimal(objDados["altura"]);
                    cont.Imc = Convert.ToDecimal(objDados["imc"]);
                    cont.StatusAluno = objDados["statusAluno"].ToString();
                    cont.Obs = objDados["obs"].ToString();
                    cont.Senha = objDados["senha"].ToString();

                    objDados.Close();
                    return cont;
                }

            }
            catch (MySqlException e)
            {
                throw (e);

            }
            finally
            {
                c.desconectar();
            }

        }


        public string alterar(clAluno aluno)
        {
            try
            {
                string sql = "UPDATE tbAluno SET " + "nomeAluno = '" + aluno.NomeAluno + "', " + "cpf = '" + aluno.Cpf + "', " + "endereco = '" + aluno.Endereco + "', " + "bairro = '" + aluno.Bairro + "', " + "cidade = '" + aluno.Cidade + "', " + "estado = '" + aluno.Estado + "', " + "cep = '" + aluno.Cep + "', " + "telefone = '" + aluno.Tel + "', " + "celular = '" + aluno.Cel + "', " + "email = '" + aluno.Email + "', " + "peso = " + aluno.Peso.ToString().Replace(",", ".") + ", " + "altura = " + aluno.Altura.ToString().Replace(",", ".") + ", " + "imc = " + Math.Round(aluno.Imc, 2).ToString().Replace(",", ".") + ", " + "statusAluno = '" + aluno.StatusAluno + "', " + "obs = '" + aluno.Obs + "', " + "senha = '" + aluno.Senha + "' " + "WHERE idAluno = " + aluno.IdAluno + ";";

                MySqlCommand sqlcmd = new MySqlCommand(sql, c.con);

                //abrir conexão
                c.conectar();
                sqlcmd.ExecuteNonQuery();

                //fechar conexão
                c.desconectar();
                return ("Atualização realizada com sucesso");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }


    }
}
