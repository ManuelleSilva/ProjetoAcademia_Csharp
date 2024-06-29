using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAcademia
{
    class clAluno
    {
        private int idAluno;
        private string nomeAluno;
        private string cpf;
        private string endereco;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;
        private string tel;
        private string cel;
        private string email;
        private decimal peso;
        private decimal altura;
        private decimal imc;
        private string statusAluno;
        private string obs;
        private string senha;

        public int IdAluno { get => idAluno; set => idAluno = value; }
        public string NomeAluno { get => nomeAluno; set => nomeAluno = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Cel { get => cel; set => cel = value; }
        public string Email { get => email; set => email = value; }
        public decimal Peso { get => peso; set => peso = value; }
        public decimal Altura { get => altura; set => altura = value; }
        public decimal Imc { get => imc; set => imc = value; }
        public string StatusAluno { get => statusAluno; set => statusAluno = value; }
        public string Obs { get => obs; set => obs = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
